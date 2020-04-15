using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using ODWai2.Misc;

namespace ODWai2.DAOs
{
    public class DataSetRepository
    {
        private string _root_dir = Path.GetFullPath(@"../../Datasets/");

        public Dictionary<string, string> get_all_data_sets()
        {
            IEnumerable<string> dirs = Directory.EnumerateDirectories(_root_dir);
            List<string> keys = new List<string>();
            List<string> values = new List<string>();
            foreach (string dir in dirs) {
                keys.Add(Path.GetFileName(dir));
                values.Add(Path.GetFullPath(dir));
            }

            return zip(keys, values);
        }

        public string root_dir()
        {
            return _root_dir;
        }

        public Dictionary<string, string> get_inference_graph(string graph_directory)
        {
            string dir = graph_directory + "/graph";
            IEnumerable<string> graphs = Directory.EnumerateFiles(dir, "*.pb", SearchOption.TopDirectoryOnly);
            List<string> keys = new List<string>();
            foreach (string graph in graphs) { keys.Add(Path.GetFileName(graph)); }
            List<string> values = graphs.ToList();

            return zip(keys, values);
        }

        public DataTable get_data_set(string data_set_directory, string type)
        {
            string dir = data_set_directory + "/" + type;
            IEnumerable<string> data_set = Directory.EnumerateFiles(dir, "*.jpg", SearchOption.TopDirectoryOnly);
            DataTable data_table = new DataTable();
            data_table.Columns.Add("id");
            data_table.Columns.Add("image_name");
            data_table.Columns.Add("image_path");
            for (int i = 0; i < data_set.Count(); ++i)
            {
                DataRow row = data_table.NewRow();
                row["id"] = i;
                string temp = data_set.ElementAt(i);
                row["image_name"] = Path.GetFileName(temp);
                row["image_path"] = temp;
                data_table.Rows.Add(row);
            }

            return data_table;
        }

        public int create_new_data_set(string to_path, string from_train_path, string from_test_path, Action<string> update = null)
        {
            Directory.CreateDirectory(to_path);
            int copied_train = copy_data_files(to_path + "/train", from_train_path, update);
            int copied_test = copy_data_files(to_path + "/test", from_test_path, update);
            copy_data_files(to_path + "/graph", null);

            return copied_test + copied_train;
        }

        public (int, string) delete_data_set(string at_path)
        {
            try
            {
                Directory.Delete(at_path, true);
            }
            catch (Exception e)
            {
                return (1, e.Message);
            }

            return (0, null);
        }

        private Dictionary<string, string> zip(List<string> keys, List<string> values)
        {
            var zip = keys.Zip(values, (k, v) => new { k, v });
            Dictionary<string, string> dict = zip.ToDictionary(x => x.k, x => x.v);

            return dict;
        }

        private int copy_data_files(string to_path, string from_path = null, Action<string> update = null)
        {
            Directory.CreateDirectory(to_path);
            if (String.IsNullOrEmpty(from_path)) { return 0; }

            Directory.CreateDirectory(to_path);
            string[] image_files = Directory.GetFiles(from_path, "*.jpg", SearchOption.TopDirectoryOnly);

            int count = 0;
            foreach (string image_file in image_files)
            {
                string image_path_lower = image_file.ToLower();
                string xml_path_lower = image_path_lower.Replace(".jpg", ".xml");
                if (File.Exists(xml_path_lower))
                {
                    ++count;
                    string image_file_lower = Path.GetFileName(image_path_lower);
                    string xml_file_lower = Path.GetFileName(xml_path_lower);

                    if (update != null) { update.Invoke(image_file_lower); }
                    File.Copy(image_file, to_path + "/" + image_file_lower);
                    if (update != null) { update.Invoke(xml_file_lower); }
                    File.Copy(xml_path_lower, to_path + "/" + xml_file_lower);
                }
            }

            return count;
        }
    }
}
