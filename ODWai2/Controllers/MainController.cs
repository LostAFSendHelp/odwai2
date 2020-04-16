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
using ODWai2.Misc.Classes;
using ODWai2.Misc.Views;

namespace ODWai2.Controllers
{
    public class MainController
    {
        private MainView _main_view;
        private DataSetView _data_set_view;
        private DataSetRepository _data_set_repo;
        private InputSetRepository _input_set_repo;
        private ScriptExecutor _script_executor;
        private FrameSelector _frame_selector;
        private NewInputSetView _new_input_set_view;
        

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _data_set_view = new DataSetView(this);
            _new_input_set_view = new NewInputSetView();
            _data_set_repo = new DataSetRepository();
            _script_executor = new ScriptExecutor();
            _input_set_repo = new InputSetRepository();
            _frame_selector = new FrameSelector((x, y, width, height) => { main_view.reload_frame_info(x, y, width, height); });
        }

        public DataSetView present_data_set_config_view()
        {
            return _data_set_view;
        }

        public void setup_python_path()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "executables (*.exe)|*.exe";
            if (dialog.ShowDialog() != DialogResult.OK) { return; }
            if (Configuration.set_python_path(dialog.FileName) == 0)
            {
                MessageBox.Show("Python path successfully set", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Path does not exist or is invalid", "Error", MessageBoxButtons.OK);
            }
        }

        public void dummy_func()
        {
        }

        public void another_dummy_func()
        {
            _data_set_view.Show();
        }

        public FrameSelector select_frame()
        {
            return _frame_selector;
        }

        public void configs_setup()
        {
            Configuration.initialize();
            if (Configuration.get_python_path() == null)
            {
                MessageBox.Show("Python interpreter not found, please setup Python path before ODWai Core can run", "Error", MessageBoxButtons.OK);
                setup_python_path();
            }
        }
        public DataTable get_input_data_sets()
        {
            return _input_set_repo.get_input_data_set();
        }

        public void load_inputset_gridview(ComboBox combobox, DataGridView gridview)
        {
            _input_set_repo.get_json_data_set(combobox, gridview);
        }

        public NewInputSetView new_input_set_view()
        {
            return _new_input_set_view;
        }
    }
}
