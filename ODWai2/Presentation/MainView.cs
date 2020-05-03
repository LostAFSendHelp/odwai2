using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using ODWai2.Controllers;

namespace ODWai2.Presentation
{
    public partial class MainView : Form
    {
        private MainController _main_controller;
        private MemoryStream _image_stream;

        public MainView()
        {
            InitializeComponent();
            _main_controller = new MainController(this);
            load_inputset_combobox();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            DialogResult confirm_quit = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo);
            if (confirm_quit == DialogResult.Yes)
            {
                base.OnClosing(e);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            _main_controller.configs_setup();
            base.OnShown(e);
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void test_btn_Click(object sender, EventArgs e)
        {
            Action on_start = () => { toggle_window_state(false); };
            Action on_complete = () => {
                toggle_window_state(true);
                update_detection_result();
            };

            int result = _main_controller.start_detection(tb_root_x.Text,
                                                        tb_root_y.Text,
                                                        tb_width.Text,
                                                        tb_height.Text,
                                                        on_start,
                                                        on_complete);

            if (result == 78)
            {
                MessageBox.Show("Please choose an inference graph in Data set configuration", "Error");
            }
            else if (result != 0)
            {
                error_message("Error executing detection, exit code: " + result);
            }
        }

        private void simulate_btn_Click(object sender, EventArgs e)
        {
            //string path = cbox_input_set.SelectedValue.ToString();
            //if (path == null) { error_message("Path to input set not found"); return; }
            //string _result = _main_controller.generate_test_cases(path);
            //if (_result == null) { MessageBox.Show("Test case generation successfully executed", "Success"); }
            //else { error_message("Error generating test cases: " + _result); }
            //return;
            Action on_start = () => { toggle_window_state(false); };
            Action on_complete = () => { toggle_window_state(true); };

            int result = _main_controller.start_simulation(on_start, on_complete);

            if (result != 0)
            {
                error_message("Error executing simulation, exit code: " + result);
            }
            else
            {
                MessageBox.Show("Simulation successfully executed", "Success");
            }
        }

        private void update_detection_result()
        {
            try
            {
                _image_stream = _main_controller.get_result_image_data();
                pb_image_result.Image = Image.FromStream(_image_stream);
                bind(dgv_detection_result, _main_controller.get_detection_result());
            }
            catch (Exception e)
            {
                error_message(e.Message);
            }
        }

        public void reload_frame_info(int x, int y, int width, int height)
        {
            tb_root_x.Text = x.ToString();
            tb_root_y.Text = y.ToString();
            tb_width.Text = width.ToString();
            tb_height.Text = height.ToString();
        }

        public void set_graph_name(string graph_name)
        {
            if (graph_name == null) { tb_graph_name.Text = "NA"; }
            else { tb_graph_name.Text = graph_name; }
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

        private void btn_data_set_config_Click(object sender, EventArgs e)
        {
            _main_controller.present_data_set_config_view().ShowDialog();
        }

        private void btn_python_path_Click(object sender, EventArgs e)
        {
            _main_controller.setup_python_path();
        }

        private void btn_region_capture_Click(object sender, EventArgs e)
        {
            Hide();
            _main_controller.select_frame().ShowDialog();
        }

        private void load_inputset_combobox()
        {
            cbox_input_set.DataSource = _main_controller.get_input_sets();
            cbox_input_set.DisplayMember = "File name";
            cbox_input_set.ValueMember = "File path";
        }

        private void btn_error_log_Click(object sender, EventArgs e)
        {
            ODWaiCore.Controllers.Helper.open_explorer_at_path(ODWaiCore.Controllers.Helper.LOG_PATH);
        }

        private void dgv_detection_result_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pb_image_result.Image = Image.FromStream(_image_stream);
                var cells = dgv_detection_result.CurrentRow.Cells;
                int root_x = int.Parse(cells["root_x"].Value.ToString());
                int root_y = int.Parse(cells["root_y"].Value.ToString());
                int width = int.Parse(cells["width"].Value.ToString());
                int height = int.Parse(cells["height"].Value.ToString());
                _main_controller.update_bounding_box(pb_image_result.Image, root_x, root_y, width, height);
                pb_image_result.Invalidate();
            }
            catch (Exception exc)
            {
                error_message(exc.Message);
            }
        }

        public void toggle_window_state(bool shown)
        {
            WindowState = shown ? FormWindowState.Normal : FormWindowState.Minimized;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            load_inputset_combobox();
        }

        private void cbox_input_set_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbox_input_set.SelectedValue == null) { return; }
            string path = cbox_input_set.SelectedValue.ToString();
            if (path == null) { return; }

            input_set_dgv.DataSource = _main_controller.get_input_set(path).Item1;
        }

        private void new_input_set_btn_Click(object sender, EventArgs e)
        {
            _main_controller.present_new_input_set_view().ShowDialog();
        }

        private void delete_input_set_btn_Click(object sender, EventArgs e)
        {
            var path = cbox_input_set.SelectedValue.ToString();
            if (path == null) { return; }
            string result = _main_controller.delete_input_set(path);

            if (result == null)
            {
                MessageBox.Show("Input set successfully deleted", "Success");
                load_inputset_combobox();
            }
            else
            {
                MessageBox.Show("Error deleting input set: " + result, "Failure");
            }
        }

        private void error_message(string message)
        {
            MessageBox.Show(message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}