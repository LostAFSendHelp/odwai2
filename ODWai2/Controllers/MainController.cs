using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Presentation;
using ODWai2.DAOs;
using ODWai2.Misc;
using System.IO;
using System.Data;
using ODWai2.ODWaiCore;

namespace ODWai2.Controllers
{
    public class MainController
    {
        private MainView _main_view;
        private DataSetView _data_set_view;
        private DataSetRepository _data_set_repo;
        private ScriptExecutor _script_executor;

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _data_set_view = new DataSetView(this);
            _data_set_repo = new DataSetRepository();
            _script_executor = new ScriptExecutor();
        }

        public DataSetView present_data_set_config_view()
        {
            return _data_set_view;
        }

        public void generate_csv(string path)
        {

        }

        public void dummy_func()
        {
        }

        public void another_dummy_func()
        {
            _data_set_view.Show();
        }
    }
}
