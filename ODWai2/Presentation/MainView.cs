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
        
        public void Load_inputset_combobox()
        {
            input_set_cbox.DataSource = _main_controller.get_input_data_sets(); //combobox inputset
            input_set_cbox.DisplayMember = "File Name"; //combobox inputset
            input_set_cbox.ValueMember = "File Name";
        }

        public void load_data()
        {
            Load_inputset_combobox();

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

        //Misc.Views.NewInputSetView form = new Misc.Views.NewInputSetView();
        private void new_input_set_btn_Click(object sender, EventArgs e)
        {
            /*Misc.Views.NewInputSetView form = new Misc.Views.NewInputSetView();
            form.Show();
            load_data();*/
            _main_controller.new_input_set_view().Show();
        }

        private void input_set_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _main_controller.load_inputset_gridview(input_set_cbox, input_set_dgv);
            
        }

        public void MainView_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
