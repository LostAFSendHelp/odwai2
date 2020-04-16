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
        
        public DataTable get_input_data_set()
        {
            //string path = @"C:\tensorflow2\models\research\object_detection\odwai-core\odwai2\ODWai2\Json";
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
            /*DirectoryInfo dir = new DirectoryInfo(path);
            foreach (FileInfo fileInf in dir.GetFiles())
            {
              data_table.Rows.Add(fileInf.Name, path + "\\" + fileInf.Name);
                
            }*/
            return data_table;
        }

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
    }
}
