using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Controllers;
using ODWai2.Interfaces;
using ODWai2.Misc.Classes;

namespace ODWai2.Presentation
{
    public partial class DataSetView : SubView, DataLoadingView
    {
        private DataSetController _data_set_controller;
        private MainController _main_controller;
        private bool _has_data_set = false;

        public DataSetView(MainController main_controller)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _data_set_controller = new DataSetController(this);
            _main_controller = main_controller;
            load_data();
        }

        public void load_data()
        {
            Dictionary<string, string> data = _data_set_controller.get_data_sets();
            if (data.Count == 0) { _has_data_set = false; return; }
            _has_data_set = true;
            bind(cbox_data_set, _data_set_controller.get_data_sets());
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

            int exit_code = _data_set_controller.generate_csv_tfrecords(data_set_dir);
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
    }
}
