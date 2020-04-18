using System;
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

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _data_set_view = new DataSetView(this);
            _script_executor = new ScriptExecutor();
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

        public void start_detection(string graph_path,
                                    string root_x,
                                    string root_y,
                                    string width,
                                    string height,
                                    Action completion)
        {
            ODWaiDetector.start_detection(graph_path, root_x, root_y, width, height, completion);
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
    }
}
