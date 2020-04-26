using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ODWai2.DAOs;
using ODWai2.Misc.Views;

namespace ODWai2.Controllers
{
    public class InputSetController
    {
        private InputSetRepository _input_set_repo;
        private NewInputSetView _new_input_set_view;

        public InputSetController(NewInputSetView newInputSetView,
                                  ref Func<DataTable> delegated_get_input_sets,
                                  ref Func<string, string> delegated_delete_input_set,
                                  ref Func<string, (JArray, string)> delegated_get_input_set)
        {
            _new_input_set_view = newInputSetView;
            _input_set_repo = new InputSetRepository(ref delegated_get_input_sets,
                                                     ref delegated_delete_input_set,
                                                     ref delegated_get_input_set);
        }

        public void Delete()
        {
            foreach (var group in _new_input_set_view.input_groups)
            {
                if (group.crr_.Checked == true)
                {
                    group.arr_.Dispose();
                }
            }
        }

        public void Save()
        {
            int count = 0;
            foreach (var group in _new_input_set_view.input_groups)
            {
                string JSONresultField_lb = JsonConvert.SerializeObject(group.lbfield_.Text);
                string JSONresultField_txt = JsonConvert.SerializeObject(group.field_.Text);
                string JSONresultAssociated_lb = JsonConvert.SerializeObject(group.lbassociated_.Text);
                string JSONresultAssociated_txt = JsonConvert.SerializeObject(group.associated_.Text.Split(','));
                string JSONresultSample_lb = JsonConvert.SerializeObject(group.lbsample_.Text);
                string JSONresultSample_txt = JsonConvert.SerializeObject(group.sample_.Text.Split(','));
                string JSONresultError_lb = JsonConvert.SerializeObject(group.lberror_.Text);
                string JSONresultError_txt = JsonConvert.SerializeObject(group.error_.Text.Split(','));

                string path;

                if (_new_input_set_view.txt_Path.Text == "")
                {
                    path = Path.GetFullPath(@"../../InputSet/");
                }
                else
                {
                    path = _new_input_set_view.txt_Path.Text;
                }

                string destPath = Path.Combine(path, _new_input_set_view.txt_fileName.Text + ".json");

                if (String.IsNullOrEmpty(_new_input_set_view.txt_fileName.Text))
                {
                    MessageBox.Show("Please input File Name", "File Name error", MessageBoxButtons.OK);
                    return;
                }

                using (var tw = new StreamWriter(destPath, true))
                {
                    if (count == 0)
                    {
                        tw.Write("[");
                    }
                    tw.Write("\n" + "{" + "\n");
                    tw.Write(JSONresultField_lb.ToString());
                    tw.Write(" : ");
                    tw.Write(JSONresultField_txt.ToString() + ",");
                    tw.WriteLine();

                    tw.Write(JSONresultAssociated_lb.ToString());
                    tw.Write(" : ");
                    tw.Write(JSONresultAssociated_txt.ToString() + ",");
                    tw.WriteLine();

                    tw.Write(JSONresultSample_lb.ToString());
                    tw.Write(" : ");
                    tw.Write(JSONresultSample_txt.ToString() + ",");
                    tw.WriteLine();

                    tw.Write(JSONresultError_lb.ToString());
                    tw.Write(" : ");
                    tw.Write(JSONresultError_txt.ToString() + "\n");
                    tw.Write("}");
                    if (count != _new_input_set_view.input_groups.Count - 1)
                    {
                        tw.Write(",");
                    }
                    else
                    {
                        tw.Write("\n" + "]");
                    }
                    tw.Close();
                    ++count;
                }
            }
            MessageBox.Show("File is Saved");
        }
    }
}
