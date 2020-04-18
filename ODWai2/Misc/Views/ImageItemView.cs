using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using System.IO;
using ODWai2.Misc.Classes;

namespace ODWai2.Misc.Views
{
    public partial class ImageItemView : SubView
    {
        private string _path;

        public ImageItemView(string image_path)
        {
            InitializeComponent();
            _path = image_path;
            init();
        }

        private void init()
        {
            string xml_path = _path.Replace("jpg", "xml");

            if (!File.Exists(_path) || !File.Exists(xml_path)) {
                MessageBox.Show("Cannot find resource file(s)", "Error", MessageBoxButtons.OK);
                return;
            }

            tb_image.Text = Path.GetFileName(_path);
            tb_xml.Text = Path.GetFileName(xml_path);
            pbox_image.Image = Image.FromFile(_path);

            void add_columns(DataTable table, string[] column_names)
            {
                foreach (string column_name in column_names)
                {
                    table.Columns.Add(new DataColumn(column_name));
                }
            }

            DataTable data_table = new DataTable();
            add_columns(data_table, new string[] { "name", "x_min", "y_min", "x_max", "y_max" });

            XElement item = XElement.Load(xml_path);
            IEnumerable<XElement> objects = item.Descendants("object");
            foreach (XElement __object in objects)
            {
                DataRow row = data_table.NewRow();
                row["name"] = __object.Descendants("name").ElementAt(0).Value.ToUpper();
                row["x_min"] = __object.Descendants("xmin").ElementAt(0).Value;
                row["y_min"] = __object.Descendants("ymin").ElementAt(0).Value;
                row["x_max"] = __object.Descendants("xmax").ElementAt(0).Value;
                row["y_max"] = __object.Descendants("ymax").ElementAt(0).Value;
                data_table.Rows.Add(row);
            }

            dgv_info.DataSource = data_table;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
