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
            Action on_start = () => { WindowState = FormWindowState.Minimized; };
            Action on_complete = () => {
                WindowState = FormWindowState.Normal;
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
                return;
            }

            if (result != 0) MessageBox.Show("Error executing detection, exit code: "
                                            + result + "\nSee the latest error log for more details" ,
                                            "Failure");
        }

        private void simulate_btn_Click(object sender, EventArgs e)
        {
            _main_controller.another_dummy_func();
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
                MessageBox.Show(e.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _main_controller.select_frame().ShowDialog();
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
                MessageBox.Show(exc.Message, "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
