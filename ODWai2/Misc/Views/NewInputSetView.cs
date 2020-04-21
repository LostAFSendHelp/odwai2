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
using ODWai2.Presentation;

namespace ODWai2.Misc.Views
{
    
    public partial class NewInputSetView : Form
    {
       
        
        Controllers.ClassCreatePanel ClassCreatePanel;
        Controllers.InputSetController InputSetController;
        public Panel[] arr_ = new Panel[100];
        public TextBox[] field_ = new TextBox[100];
        public TextBox[] associated_ = new TextBox[100];
        public TextBox[] sample_ = new TextBox[100];
        public TextBox[] error_ = new TextBox[100];
        public Label[] lbfield_ = new Label[100];
        public Label[] lbassociated_ = new Label[100];
        public Label[] lbsample_ = new Label[100];
        public Label[] lberror_ = new Label[100];
        public CheckBox[] crr_ = new CheckBox[100];

        
        public NewInputSetView()
        {
            InitializeComponent();
            ClassCreatePanel = new Controllers.ClassCreatePanel(this);
            InputSetController = new Controllers.InputSetController(this);
            arr_[0] = pnl_0;
            crr_[0] = chbox_0;
            field_[0] = txt_field_0;
            associated_[0] = txt_associated_0;
            sample_[0] = txt_sampleInput_0;
            error_[0] = txt_errorInput_0;
            lbfield_[0] = lb_field_0;
            lbassociated_[0] = lb_associal_0;
            lbsample_[0] = lb_sample_0;
            lberror_[0] = lb_error_0;
        }

        public int s = 0;
        private void btn_new_field_Click(object sender, EventArgs e)
        {
            s++;
            flowLayoutPanel1.Controls.Add(arr_[s] = ClassCreatePanel.Create(s));
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                for (int i = s + 1; i < Convert.ToInt32(txt_numberField.Text); ++i)
                {
                    flowLayoutPanel1.Controls.Add(arr_[i] = ClassCreatePanel.Create(i));
                    s = i;
                }
                MessageBox.Show("This Form have " + Convert.ToInt32(txt_numberField.Text) + " field");
            }
        }

        private void btn_delete_field_Click(object sender, EventArgs e)
        {
            InputSetController.Delete();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            InputSetController.Save();
            
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                txt_Path.Text = browser.SelectedPath;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
           
        }
    }
}
