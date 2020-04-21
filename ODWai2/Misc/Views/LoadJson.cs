using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Presentation;
using ODWai2.DAOs;
using ODWai2.Controllers;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ODWai2.Misc.Views
{
    public partial class LoadJson : Form
    {
        InputSetRepository _input_set_respository;
        MainView _main_view;
        public LoadJson()
        {
            InitializeComponent();
            _input_set_respository = new InputSetRepository();
            _main_view = new MainView();
            load();
        }

        public void load()
        {
            string destPath = _input_set_respository.get_path_json(_main_view.input_set_cbox);
            string Json = File.ReadAllText(destPath);
            var json = JArray.Parse(Json);
            //var fields = JArray.Parse(json["Field"].ToString());
            //JArray fieldArray = (JArray)json["Field"];

            for (var i = 0; i < json.Count; i++)
            {
                var fields = JObject.Parse(json[i].ToString())["Field"];
                var associated = JObject.Parse(json[i].ToString())["Associated texts"];
                var sample = JObject.Parse(json[i].ToString())["Sample input"];
                var error = JObject.Parse(json[i].ToString())["Error input"];

                txt_associated.Text = associated.ToString();
                txt_sample.Text = sample.ToString();
                txt_eror.Text = error.ToString();
               // MessageBox.Show(fields.ToString() + associated.ToString() + sample.ToString() + error.ToString());
            }
        }
    }
}
