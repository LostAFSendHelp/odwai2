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
using ODWai2.DAOs;
using ODWai2.Misc.Classes;

namespace ODWai2.Misc.Views
{
    public partial class NewDataSetView : SubView
    {
        private const string _root_dir = @"../../Datasets/";
        private DataSetRepository _data_set_repo;
        private DataLoadingView _caller_view;

        public NewDataSetView(DataLoadingView caller_view, DataSetRepository data_set_repo)
        {
            InitializeComponent();
            _data_set_repo = data_set_repo;
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

            LoadingProgressView loading_view = new LoadingProgressView();
            loading_view.Show();
            Action<string> update = (z) => { loading_view.set_progress("Importing: <" + z + "> to " + data_set_name.ToUpper()); };
            int result = _data_set_repo.create_new_data_set(destination_path, train_path_origin, test_path_origin, update);
            loading_view.Close();
            MessageBox.Show(result + " data item(s) have been imported", "Success", MessageBoxButtons.OK);
            _caller_view.load_data();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
