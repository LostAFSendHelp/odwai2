using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using ODWai2.Controllers;

namespace ODWai2.Presentation
{
    public partial class MainView : Form
    {
        private MainController _main_controller;

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
                MemoryStream stream = new MemoryStream();
                Image.FromFile(Path.GetFullPath("../../temp result/temp.png")).Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Position = 0;
                Image temp = Image.FromStream(stream);
                pb_image_result.Image = temp.Clone() as Image;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
    }
}
