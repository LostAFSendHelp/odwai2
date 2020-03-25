using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ODWai2.DAOs
{
    class DataSetRepository
    {
        private const string root_dir = @"../../Datasets/";

        public Dictionary<string, string> get_all_data_sets()
        {
            IEnumerable<string> dirs = Directory.EnumerateDirectories(root_dir);
            List<string> keys = new List<string>();
            List<string> values = new List<string>();
            foreach (string dir in dirs) {
                keys.Add(Path.GetFileName(dir));
                values.Add(Path.GetFullPath(dir));
            }

            return zip(keys, values);
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

        private Dictionary<string, string> zip(List<string> keys, List<string> values)
        {
            var zip = keys.Zip(values, (k, v) => new { k, v });
            Dictionary<string, string> dict = zip.ToDictionary(x => x.k, x => x.v);

            return dict;
        }
    }
}
