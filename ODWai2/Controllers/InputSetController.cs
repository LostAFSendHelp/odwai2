using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODWai2.Presentation;
using ODWai2.Misc.Views;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using ODWai2.DAOs;

namespace ODWai2.Controllers
{
    class InputSetController
    {
        private InputSetView input_set_view;
        private InputSetRepository input_set_repo;
        public InputSetController(InputSetView input_set_view)
        {
           this.input_set_view = input_set_view;
           input_set_repo = new InputSetRepository();
            
        }
        public InputSetController(NewInputSetView newInputSetView)
        {
            NewInputSetView = newInputSetView;
            
        }

        

        Misc.Views.NewInputSetView NewInputSetView;


        public void Delete()
        {
            for (int i = 0; i <= NewInputSetView.s; ++i)
            {
                if (NewInputSetView.crr_[i].Checked == true)
                {
                    NewInputSetView.arr_[i].Dispose();
                }
            }
        }
        public void Save()
        {
            for (int i = 0; i <= NewInputSetView.s; ++i)
            {
                string JSONresultField_lb = JsonConvert.SerializeObject(NewInputSetView.lbfield_[i].Text);
                string JSONresultField_txt = JsonConvert.SerializeObject(NewInputSetView.field_[i].Text);
                string JSONresultAssociated_lb = JsonConvert.SerializeObject(NewInputSetView.lbassociated_[i].Text);
                string JSONresultAssociated_txt = JsonConvert.SerializeObject(NewInputSetView.associated_[i].Text.Split(','));
                string JSONresultSample_lb = JsonConvert.SerializeObject(NewInputSetView.lbsample_[i].Text);
                string JSONresultSample_txt = JsonConvert.SerializeObject(NewInputSetView.sample_[i].Text.Split(','));
                string JSONresultError_lb = JsonConvert.SerializeObject(NewInputSetView.lberror_[i].Text);
                string JSONresultError_txt = JsonConvert.SerializeObject(NewInputSetView.error_[i].Text.Split(','));

                string path;

                if (NewInputSetView.txt_Path.Text == "")
                {
                    path = Path.GetFullPath(@"../../InputSet/");
                    //path = @"C:\tensorflow2\models\research\object_detection\odwai-core\odwai2\ODWai2\Json\";
                }
                else
                {
                    path = NewInputSetView.txt_Path.Text;
                }

                string destPath = System.IO.Path.Combine(path, NewInputSetView.txt_fileName.Text + ".json");

                if (String.IsNullOrEmpty(NewInputSetView.txt_fileName.Text))
                {
                    MessageBox.Show("Please input File Name", "File Name error", MessageBoxButtons.OK);
                    return;
                }

                using (var tw = new StreamWriter(destPath, true))
                {
                    if (i == 0)
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
                    if (i != NewInputSetView.s)
                    {
                        tw.Write(",");
                    }
                    if (i == NewInputSetView.s)
                    {
                        tw.Write("\n" + "]");
                    }
                    tw.Close();
                }
                MessageBox.Show("File is Saved");
            }

        }
    }
}
