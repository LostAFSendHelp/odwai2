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
using ODWai2.Interfaces;

namespace ODWai2.Misc
{
    public partial class NewDataSetView : Form
    {
        private const string _root_dir = @"../../Datasets/";
        private DataLoadingView _caller_view;

        public NewDataSetView(DataLoadingView caller_view)
        {
            InitializeComponent();
            _caller_view = caller_view;
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
                tb_test_path.Text = browser.SelectedPath;
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
            string destination_path = absolute_path + "/" + data_set_name;

            if (Directory.Exists(destination_path))
            {
                MessageBox.Show("This data set name has already been taken", "Naming error", MessageBoxButtons.OK);
                return;
            }

            Directory.CreateDirectory(destination_path);
            int copied_train = copy_data_files(destination_path + "/train", train_path_origin);
            int copied_test = copy_data_files(destination_path + "/test", test_path_origin);
            copy_data_files(destination_path + "/graph");

            MessageBox.Show((copied_test + copied_train) + " data item(s) have been imported", "Success", MessageBoxButtons.OK);
            _caller_view.load_data();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private int copy_data_files(string to_path, string from_path = null)
        {
            Directory.CreateDirectory(to_path);
            if (String.IsNullOrEmpty(from_path)) { return 0; }

            Directory.CreateDirectory(to_path);
            string[] image_files = Directory.GetFiles(from_path, "*.jpg", SearchOption.TopDirectoryOnly);

            int count = 0;
            foreach (string image_file in image_files)
            {
                string xml_file = image_file.Replace(".jpg", ".xml").Replace(".JPG", ".xml");
                if (File.Exists(xml_file))
                {
                    ++count;
                    File.Copy(image_file, to_path + "/" + Path.GetFileName(image_file));
                    File.Copy(xml_file, to_path + "/" + Path.GetFileName(xml_file));
                }
            }

            return count;
        }
    }
}
