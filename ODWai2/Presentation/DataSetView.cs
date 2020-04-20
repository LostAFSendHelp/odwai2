using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ODWai2.Controllers;
using ODWai2.Interfaces;
using ODWai2.Misc.Classes;
using ODWai2.Misc.Views;
using System.ComponentModel;

namespace ODWai2.Presentation
{
    public partial class DataSetView : SubView, DataLoadingView
    {
        private DataSetController _data_set_controller;
        private Action<string> _on_closing;
        private bool _has_data_set = false;

        public DataSetView(Action<string> on_closing)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _data_set_controller = new DataSetController(this);
            _on_closing = on_closing;

            tb_data_set_path.ReadOnly = true;
            tb_graph_path.ReadOnly = true;
        }

        protected override void OnShown(EventArgs e)
        {
            load_data();
            base.OnShown(e);
        }

        // reload graph info on MainView and MainController
        protected override void OnDeactivate(EventArgs e)
        {
            string graph = get_graph_path();
            _on_closing(get_graph_path());
            base.OnDeactivate(e);
        }

        public void load_data()
        {
            Dictionary<string, string> data = _data_set_controller.get_data_sets();
            if (data.Count == 0) { _has_data_set = false; flush_data(); return; }
            _has_data_set = true;
            bind(cbox_data_set, _data_set_controller.get_data_sets());
        }

        private string get_graph_path()
        {
            KeyValuePair<string, string>? pair = cbox_graph.SelectedValue as KeyValuePair<string, string>?;
            return pair?.Value;
        }

        private void flush_data()
        {
            cbox_data_set.DataSource = null;
            dgv_data_set_testing.DataSource = null;
            dgv_data_set_training.DataSource = null;
            tb_data_set_path.Text = string.Empty;
            tb_graph_path.Text = string.Empty;
        }

        private void bind(Control item, object source)
        {
            switch (item)
            {
                case ComboBox i:
                    i.DataSource = new BindingSource(source as Dictionary<string, string>, null);
                    i.DisplayMember = "key";
                    break;
                case DataGridView i:
                    i.DataSource = source as DataTable;
                    break;
                default:
                    return;
            }
        }

        private string get_current_data_set()
        {
            if (!_has_data_set) { return null; }
            return ((KeyValuePair<string, string>)cbox_data_set.SelectedValue).Value;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cbox_data_set_SelectedValueChanged(object sender, EventArgs e)
        {
            string data_set_dir = get_current_data_set();
            if (data_set_dir == null) { return; }

            bind(cbox_graph, _data_set_controller.get_inference_graphs(data_set_dir));
            bind(dgv_data_set_training, _data_set_controller.get_train_data(data_set_dir));
            bind(dgv_data_set_testing, _data_set_controller.get_test_data(data_set_dir));

            tb_data_set_path.Text = data_set_dir;
            tb_graph_path.Text = data_set_dir + @"\graph";
        }

        private void cbox_graph_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void btn_data_set_dir_Click(object sender, EventArgs e)
        {
            _data_set_controller.open_explorer_at_path(tb_data_set_path.Text);
        }

        private void btn_graph_dir_Click(object sender, EventArgs e)
        {
            _data_set_controller.open_explorer_at_path(tb_graph_path.Text);
        }

        private void btn_new_data_set_Click(object sender, EventArgs e)
        {
            _data_set_controller.present_new_data_set_view().ShowDialog();
        }

        private void btn_generate_training_resources_Click(object sender, EventArgs e)
        {
            string data_set_dir = get_current_data_set();
            if (data_set_dir == null) { return; }

            LoadingProgressView loading_view = new LoadingProgressView();
            loading_view.Show();
            int exit_code = _data_set_controller.generate_csv_tfrecords(data_set_dir, (status) => { loading_view.set_progress(status); });
            loading_view.Close();

            if (exit_code == 0)
            {
                MessageBox.Show("Training resources successfully generated", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Unexpected error while generating Resources for training. Exit code: " + exit_code, "Failure", MessageBoxButtons.OK);
            }
        }

        private void dgv_data_set_training_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            if (view == null) { return; }

            _data_set_controller.present_image_item_view(view.CurrentRow.Cells["image_path"].Value.ToString()).ShowDialog();
        }

        private void dgv_data_set_testing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            if (view == null) { return; }

            _data_set_controller.present_image_item_view(view.CurrentRow.Cells["image_path"].Value.ToString()).ShowDialog();
        }

        private void btn_delete_data_set_Click(object sender, EventArgs e)
        {
            string data_set_path = get_current_data_set();
            if (data_set_path == null) { return; }

            string data_set_name = new DirectoryInfo(data_set_path).Name.ToUpper();
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + data_set_name + "?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) { return; }

            (int code, string message) = _data_set_controller.delete_data_set(data_set_path);
            if (code == 0)
            {
                MessageBox.Show("Data set " + data_set_name + " successfully deleted", "Success", MessageBoxButtons.OK);
                load_data();
            }
            else
            {
                MessageBox.Show("Error: " + message, "Failure", MessageBoxButtons.OK);
            }
        }

        private void btn_import_graph_Click(object sender, EventArgs e)
        {
            string data_set_path = get_current_data_set();
            if (data_set_path == null) { return; }

            var result = MessageBox.Show("An inference graph from unidentified outer sources may cause unexpected error or undesirable detection results. Proceed if you are sure the graph was generated using reliable data and configurations",
                                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) { return; }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PB text files|*.pb";

            if (dialog.ShowDialog() != DialogResult.OK) { return; }
            // TODO: currently allows overwriting, implement formal process if time allows

            string graph_name = Path.GetFileName(dialog.FileName);
            string message = "Importing <" + graph_name + "> to " + new DirectoryInfo(data_set_path).Name.ToUpper();
            LoadingProgressView loading_view = new LoadingProgressView(message);
            loading_view.Show();
            _data_set_controller.import_graph(Path.Combine(data_set_path, "graph"), dialog.FileName);
            loading_view.Close();

            bind(cbox_graph, _data_set_controller.get_inference_graphs(data_set_path));
        }
    }
}
