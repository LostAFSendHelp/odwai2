using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODWai2.DAOs
{
    class InputSetRepository
    {
        

        

        public void get_json_data_set(ComboBox combobox, DataGridView gridview)
        {
            //string path = @"C:\tensorflow2\models\research\object_detection\odwai-core\odwai2\ODWai2\Json\";

            string path = Path.GetFullPath(@"../../InputSet/");

            DataRow selectedDataRow = ((DataRowView)combobox.SelectedItem).Row; // doc file name : a1.json
            string select = selectedDataRow["File Name"].ToString();// doc file name : a1.json

            string destPath = System.IO.Path.Combine(path, select);

            string Json = File.ReadAllText(destPath);
            var Jarray = JArray.Parse(Json);
            gridview.DataSource = Jarray;
        }
        public void delete_json_data_set(ComboBox combobox)
        {
            string path = Path.GetFullPath(@"../../InputSet/");
            DataRow selectedDataRow = ((DataRowView)combobox.SelectedItem).Row; // doc file name : a1.json
            string select = selectedDataRow["File Name"].ToString();// doc file name : a1.json
            string destPath = System.IO.Path.Combine(path, select);

            DialogResult result = MessageBox.Show("Are you sure you want to delete " + select + "?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) { return; }
            try
            {
               if (File.Exists(destPath))
               {
                    File.Delete(destPath);
                    MessageBox.Show("File " + select + " successfully deleted", "Success", MessageBoxButtons.OK);
               }
               else Console.WriteLine("File not found");
               }
            catch (IOException)
            {
               MessageBox.Show("Error: " + select, "Failure", MessageBoxButtons.OK);
            }
            load_data_input_set_cbox(combobox);
        }

        public void load_data_input_set_cbox(ComboBox comboBox)
        {
            string path = Path.GetFullPath(@"../../InputSet/");
            string[] files = Directory.GetFiles(path);
            DataTable data_table = new DataTable();
            data_table.Columns.Add("File Name");
            data_table.Columns.Add("File Path");
            for (int i = 0; i < files.Length; i++)
            {

                FileInfo file = new FileInfo(files[i]);
                data_table.Rows.Add(file.Name, path + "\\" + file.Name);
            }
            comboBox.DataSource = data_table;
            comboBox.DisplayMember = "File name";
            comboBox.ValueMember = "File name";

        }
        
    }
}
