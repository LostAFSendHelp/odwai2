using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Controllers;

namespace ODWai2.Misc
{
    public partial class NewInputSetView : Form
    {
        Controllers.ClassCreatePanel ClassCreatePanel;
        public NewInputSetView()
        {
            InitializeComponent();
            ClassCreatePanel = new Controllers.ClassCreatePanel(this);
        }

        int s = 1;
        private void btn_new_field_Click(object sender, EventArgs e)
        {
            s++;
            flowLayoutPanel1.Controls.Add(ClassCreatePanel.Create(s));
            
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
                for(int i = s+1 ; i<= Convert.ToInt32(txt_numberField.Text); i++)
                {
                    flowLayoutPanel1.Controls.Add(ClassCreatePanel.Create(i));
                    s = i;
                }
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = browser.SelectedPath;
            }
        }
    }
}
