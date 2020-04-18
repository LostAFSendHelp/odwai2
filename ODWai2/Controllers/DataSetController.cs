using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ODWai2.Presentation;
using ODWai2.DAOs;
using ODWai2.Misc.Views;
using ODWai2.ODWaiCore;
using System.Data;
using System.IO;

namespace ODWai2.Controllers
{
    class DataSetController
    {
        private DataSetView _data_set_view;
        private DataSetRepository _data_set_repo;

        public DataSetController(DataSetView data_set_view)
        {
            _data_set_view = data_set_view;
            _data_set_repo = new DataSetRepository();
        }

        public string get_root_dir()
        {
            return _data_set_repo.root_dir();
        }

        public Dictionary<string, string> get_data_sets()
        {
            return _data_set_repo.get_all_data_sets();
        }

        public Dictionary<string, string> get_inference_graphs(string graph_directory)
        {
            return _data_set_repo.get_inference_graph(graph_directory);
        }

        public DataTable get_train_data(string data_set_path)
        {
            return _data_set_repo.get_data_set(data_set_path, "train");
        }

        public DataTable get_test_data(string data_set_path)
        {
            return _data_set_repo.get_data_set(data_set_path, "test");
        }

        public NewDataSetView present_new_data_set_view()
        {
            return new NewDataSetView(_data_set_view, _data_set_repo);
        }

        public ImageItemView present_image_item_view(string path)
        {
            return new ImageItemView(path);
        }

        public void open_explorer_at_path(string path)
        {
            if (path.Trim().Length == 0 || !Directory.Exists(path)) { return; }
            Process.Start("explorer", path);
        }

        public int generate_csv_tfrecords(string data_set_path, Action<string> update = null)
        {
            if (update != null) { update.Invoke("Generating CVs"); }
            int xml_to_csv = ScriptExecutor.python_execute("xml_to_csv.py", 5, ("path", get_path_argument(data_set_path)));
            switch (xml_to_csv)
            {
                case 98:
                case 99:
                    return xml_to_csv;
                case 1:
                    return 91;
                case 0:
                    return generate_tf_records();
                default:
                    return 1;
            }

            int generate_tf_records()
            {
                if (update != null) { update.Invoke("Generating Tensorflow Records from CVs"); }
                int generate_records = ScriptExecutor.python_execute("generate_tf_records.py", 60, ("path", get_path_argument(data_set_path)));
                switch (generate_records)
                {
                    case 0:
                    case 88:
                    case 89:
                        return generate_records;
                    case 1:
                        return 81;
                    default:
                        return 2;
                }
            }
        }

        public int generate_records(string data_set_path)
        {
            return ScriptExecutor.python_execute("generate_tf_records.py");
        }

        public (int, string) delete_data_set(string data_set_path)
        {
            return _data_set_repo.delete_data_set(data_set_path);
        }

        public void import_graph(string to_path, string from_path)
        {
            _data_set_repo.import_graph(to_path, from_path);
        }

        private string get_path_argument(string raw_string)
        {
            return "\"" + raw_string.Replace("\\", "/") + "\"";
        }
    }
}
