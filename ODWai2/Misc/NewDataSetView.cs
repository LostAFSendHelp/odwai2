using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ODWai2.Misc
{
    public partial class NewDataSetView : Form
    {
        private const string _root_dir = @"../../Datasets/";

        public NewDataSetView()
        {
            InitializeComponent();
        }

        private void btn_browse_train_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                tb_train_path.Text = browser.SelectedPath;
            }
        }

        private void btn_browse_test_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                tb_train_path.Text = browser.SelectedPath;
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string train_path_origin = tb_train_path.Text.Trim();
            string test_path_origin = tb_test_path.Text.Trim();
            string data_set_name = tb_data_set_name.Text.Trim();

            if (String.IsNullOrEmpty(train_path_origin) || 
                String.IsNullOrEmpty(test_path_origin) ||
                String.IsNullOrEmpty(data_set_name) ||
                !Directory.Exists(train_path_origin) ||
                !Directory.Exists(test_path_origin))
            {
                MessageBox.Show("Invalid entries or paths do not exist", "Input error", MessageBoxButtons.OK);
                return;
            }

            string absolute_path = Path.GetFullPath(_root_dir);
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
