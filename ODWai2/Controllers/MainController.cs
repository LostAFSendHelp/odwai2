﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Presentation;
using ODWai2.DAOs;
using System.IO;
using System.Data;

namespace ODWai2.Controllers
{
    public class MainController
    {
        private MainView _main_view;
        private DataSetView _data_set_view;
        private DataSetRepository _data_set_repo;

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _data_set_view = new DataSetView(this);
            _data_set_repo = new DataSetRepository();
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

        public void dummy_func()
        {
            MessageBox.Show("fuck you", _main_view.Name, MessageBoxButtons.OK);
        }

        public void another_dummy_func()
        {
            _data_set_view.Show();
        }
    }
}