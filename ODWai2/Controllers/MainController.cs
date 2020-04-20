using System;
using System.IO;
using System.Windows.Forms;
using ODWai2.Presentation;
using ODWai2.ODWaiCore;
using ODWai2.Misc.Classes;
using ODWai2.Misc.Views;
using ODWai2.ODWaiCore.Controllers;

namespace ODWai2.Controllers
{
    public class MainController
    {
        private MainView _main_view;
        private DataSetView _data_set_view;
        private ScriptExecutor _script_executor;
        private FrameSelector _frame_selector;
        private string _graph_path;

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _script_executor = new ScriptExecutor();
            _frame_selector = new FrameSelector((x, y, width, height) => { main_view.reload_frame_info(x, y, width, height); });
            _main_view.set_graph_name(null);
            _data_set_view = new DataSetView((graph_path) => { set_graph_path(graph_path); });
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

        public int start_detection(string root_x,
                                    string root_y,
                                    string width,
                                    string height,
                                    Action start,
                                    Action completion)
        {
            if (_graph_path == null) { return 71; }
            (int code, string output) = ODWaiDetector.start_detection(_graph_path, root_x, root_y,
                                                width, height, start, completion);
            if (output != null) { Helper.log_error(output); }
            return code;
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

        public void set_graph_path(string graph_path)
        {
            _graph_path = graph_path;
            _main_view.set_graph_name(get_graph_name());
        }

        public string get_graph_name()
        {
            if (_graph_path == null) { return null; }
            return Path.GetFileName(_graph_path);
        }
    }
}
