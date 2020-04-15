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

namespace ODWai2.Presentation
{
    public partial class MainView : Form, DataLoadingView
    {
        private MainController _main_controller;

        public MainView()
        {
            InitializeComponent();
            _main_controller = new MainController(this);
            load_data();
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
            _main_controller.dummy_func();
        }

        private void simulate_btn_Click(object sender, EventArgs e)
        {
            _main_controller.another_dummy_func();
        }

        public void load_data()
        {

        }

        public void reload_frame_info(int x, int y, int width, int height)
        {
            tb_root_x.Text = x.ToString();
            tb_root_y.Text = y.ToString();
            tb_width.Text = width.ToString();
            tb_height.Text = height.ToString();
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

        private void btn_generate_csv_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_data_set_config_Click(object sender, EventArgs e)
        {
            _main_controller.present_data_set_config_view().Show();
        }

        private void btn_python_path_Click(object sender, EventArgs e)
        {
            _main_controller.setup_python_path();
        }

        private void btn_region_capture_Click(object sender, EventArgs e)
        {
            _main_controller.select_frame().ShowDialog();
        }
    }
}
