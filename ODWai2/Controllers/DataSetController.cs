using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;
using System.IO;
using ODWai2.Presentation;
using ODWai2.DAOs;
using ODWai2.Misc.Views;
using ODWai2.ODWaiCore.Controllers;

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
            return _data_set_repo.get_inference_graphs(graph_directory);
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

        public int generate_csv_tfrecords(string data_set_path, Action<string> update = null)
        {
            (int result, string output) = ODWaiTrainer.generate_training_resources(data_set_path, update);
            if (output != null) { Helper.log_error(output); }
            return result;
        }

        public (int, string) delete_data_set(string data_set_path)
        {
            return _data_set_repo.delete_data_set(data_set_path);
        }

        public (int, string) start_training(string data_set_path)
        {
            return ODWaiTrainer.start_training(data_set_path);
        }

        public (int, string) generate_graph(string data_set_path, Action<string> start = null)
        {
            (int code, string output) = ODWaiTrainer.export_graph(data_set_path, start);
            if (code != 0 && output != null) { Helper.log_error(output); }
            return (code, output);
        }

        public void import_graph(string to_path, string from_path)
        {
            _data_set_repo.import_graph(to_path, from_path);
        }
    }
}
