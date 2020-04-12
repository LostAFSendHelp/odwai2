using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using ODWai2.Controllers;
using ODWai2.Interfaces;
using ODWai2.Misc;

namespace ODWai2.Presentation
{
    public partial class MainView : Form, DataLoadingView
    {
        private MainController _main_controller;
        private bool _has_data_set = false;

        public MainView()
        {
            InitializeComponent();
            _main_controller = new MainController(this);
            load_data();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            DialogResult confirm_quit = MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo);
            if (confirm_quit == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            Dictionary<string, string> data = _main_controller.get_data_sets();
            if (data.Count == 0) { _has_data_set = false; return; }
            _has_data_set = true;
            bind(cbox_data_set, _main_controller.get_data_sets());
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

        private void cbox_data_set_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_has_data_set) { return; }
            string dir = ((KeyValuePair<string, string>)cbox_data_set.SelectedValue).Value;
            bind(cbox_inference_graph, _main_controller.get_inference_graphs(dir));
            bind(dgv_train, _main_controller.get_train_data(dir));
            bind(dgv_test, _main_controller.get_test_data(dir));
        }

        private void dgv_train_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView view = sender as DataGridView;
            if (view == null) { return; }

            _main_controller.preset_image_item_view(view.CurrentRow.Cells["image_path"].Value.ToString()).ShowDialog();
        }

        private void btn_new_data_set_Click(object sender, EventArgs e)
        {
            _main_controller.present_new_data_set_view().ShowDialog();
        }


        //code tu day
        private void new_input_set_btn_Click(object sender, EventArgs e)
        {
            Misc.NewInputSetView form = new Misc.NewInputSetView();
            form.Show();
        }



        private void input_set_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void MainView_Load(object sender, EventArgs e)
        {
            string path = @"C:\tensorflow2\models\research\object_detection\odwai-core\odwai2\ODWai2\Json";
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Path");

            string[] files = Directory.GetFiles(path);

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);

                table.Rows.Add(file.Name, path + "\\" + file.Name);
                
            }

            // using foreach loop

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo fileInf in dir.GetFiles())
            {
                if (fileInf.Name == ".jon")
                {
                    table.Rows.Add(fileInf.Name, path + "\\" + fileInf.Name);
                }
            }

            input_set_cbox.DataSource = table;
            input_set_cbox.DisplayMember = "File Name";

        }
    }
}
