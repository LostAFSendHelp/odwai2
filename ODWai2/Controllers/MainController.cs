using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using ODWai2.Presentation;
using ODWai2.ODWaiCore;
using ODWai2.Misc.Classes;
using ODWai2.Misc.Views;
using ODWai2.ODWaiCore.Controllers;
using ODWai2.ODWaiCore.Models;
using Newtonsoft.Json.Linq;

namespace ODWai2.Controllers
{
    public class MainController
    {
        private MainView _main_view;
        private DataSetView _data_set_view;
        private NewInputSetView _new_input_set_view;
        private ScriptExecutor _script_executor;
        private FrameSelector _frame_selector;
        private string _graph_path;

        private Func<DataTable> _get_input_sets = null;
        private Func<string, string> _delete_input_set = null;
        private Func<string, (JArray, string)> _get_input_set = null;

        public MainController(MainView main_view)
        {
            _main_view = main_view;
            _script_executor = new ScriptExecutor();
            _main_view.set_graph_name(null);
            _data_set_view = new DataSetView((graph_path) => { set_graph_path(graph_path); });

            _frame_selector = new FrameSelector((x, y, width, height) => {
                    main_view.reload_frame_info(x, y, width, height);
                    main_view.Show();
            });

            _new_input_set_view = new NewInputSetView(ref _get_input_sets,
                                                      ref _delete_input_set,
                                                      ref _get_input_set);
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

        public int start_simulation(Action start, Action completion)
        {
            (int code, string output) = ODWaiSimulator.start_simulation(start, completion);
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

        public MemoryStream get_result_image_data()
        {
            MemoryStream stream = new MemoryStream();
            Image.FromFile(Path.GetFullPath("../../temp result/temp.png")).Save(stream, ImageFormat.Png);
            stream.Position = 0;

            return stream;
        }

        public DataTable get_detection_result()
        {
            DataTable result_table = new DataTable();
            string[] fields = new[] { "id", "class_name", "bias", "root_x",
                                    "root_y", "width", "height", "inner_text"};

            foreach (string field in fields)
            {
                DataColumn column = new DataColumn(field);
                result_table.Columns.Add(column);
            }

            int count = 0;
            foreach (DetectionResult result in DetectionResult.from_json(@"../../temp result/temp.json"))
            {
                DataRow result_row = result_table.NewRow();
                result_row["id"] = ++count;
                result_row["class_name"] = result.class_name;
                result_row["bias"] = result.bias;
                result_row["width"] = result.width;
                result_row["height"] = result.height;
                result_row["root_x"] = result.root_x;
                result_row["root_y"] = result.root_y;
                result_row["inner_text"] = result.text;

                result_table.Rows.Add(result_row);
            }
            return result_table;
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

        public void update_bounding_box(Image image, int root_x, int root_y, int width, int height)
        {
            Helper.draw_bounding_box(image, root_x, root_y, width, height);
        }

        public NewInputSetView present_new_input_set_view()
        {
            return _new_input_set_view;
        }

        public (JArray, string) get_input_set(string path)
        {
            return _get_input_set(path);
        }

        public string delete_input_set(string path)
        {
            return _delete_input_set(path);
        }

        public DataTable get_input_sets()
        {
            return _get_input_sets();
        }
    }
}
