using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ODWai2.Presentation;
using ODWai2.DAOs;
using ODWai2.Misc;
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

        public int generate_csv(string data_set_path)
        {
            ScriptExecutor exe = new ScriptExecutor();
            return exe.python_execute("xml_to_csv.py", ("path", get_path_argument(data_set_path)));
        }

        public int generate_records(string data_set_path)
        {
            ScriptExecutor exe = new ScriptExecutor();
            return exe.python_execute("generate_tf_records.py");
        }

        private string get_path_argument(string raw_string)
        {
            return "\"" + raw_string.Replace("\\", "/") + "\"";
        }
    }
}
