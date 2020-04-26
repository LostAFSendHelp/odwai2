using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ODWai2.DAOs
{
    class InputSetRepository
    {
        private string _input_set_path = Path.GetFullPath(@"../../InputSet/");

        public InputSetRepository(ref Func<DataTable> delegated_get_input_sets,
                                  ref Func<string, string> delegated_delete_input_set,
                                  ref Func<string, (JArray, string)> delegated_get_input_set)
        {
            Directory.CreateDirectory(_input_set_path);
            delegated_get_input_sets = () => { return get_input_sets(); };
            delegated_delete_input_set = (path) => { return delete_input_set(path); };
            delegated_get_input_set = (path) => { return get_input_set(path); };
        }

        public string get_name_json(ComboBox combobox)
        {
            
            DataRow selectedDataRow = ((DataRowView)combobox.SelectedItem).Row; // doc file name : a1.json
            string select = selectedDataRow["File Name"].ToString();// doc file name : a1.json

            return select;
        }
        public string get_path_json(ComboBox comboBox)
        {
            string destPath = Path.Combine(_input_set_path, get_name_json(comboBox));
            return destPath;
        }

        public (JArray, string) get_input_set(string path)
        {
            try
            {
                string Json = File.ReadAllText(path);
                var data = JArray.Parse(Json);
                return (data, null);
            }
            catch (Exception e)
            {
                return (null, e.Message);
            }
        }

        private DataTable get_input_sets()
        {
            string[] files = Directory.GetFiles(_input_set_path, "*.json", SearchOption.TopDirectoryOnly);
            DataTable data_table = new DataTable();
            data_table.Columns.Add("File name");
            data_table.Columns.Add("File path");
            foreach (string file in files)
            {
                FileInfo file_info = new FileInfo(file);
                data_table.Rows.Add(file_info.Name, file_info.FullName);
            }

            return data_table;
        }

        private string delete_input_set(string path)
        {
            try
            {
                string full_path = Path.GetFullPath(path);
                File.Delete(path);
                return null;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
