using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using ODWai2.Controllers;
using ODWai2.Misc.Classes;
using Newtonsoft.Json.Linq;

namespace ODWai2.Misc.Views
{
    
    public partial class NewInputSetView : Form
    {
        ClassCreatePanel ClassCreatePanel;
        InputSetController InputSetController;

        public List<InputGroup> input_groups;
        public int s = 0;

        public NewInputSetView(ref Func<DataTable> delegated_get_input_sets,
                               ref Func<string, string> delegated_delete_input_set,
                               ref Func<string, (JArray, string)> delegated_get_input_set)
        {
            InitializeComponent();
            ClassCreatePanel = new ClassCreatePanel(this);
            InputSetController = new InputSetController(this,
                                                        ref delegated_get_input_sets,
                                                        ref delegated_delete_input_set,
                                                        ref delegated_get_input_set);
            InputGroup group_0 = new InputGroup() {
                arr_ = pnl_0, crr_ = chbox_0, field_ = txt_field_0,
                associated_ = txt_associated_0, sample_ = txt_sampleInput_0,
                error_ = txt_errorInput_0, lbfield_ = lb_field_0, lbassociated_ = lb_associal_0,
                lbsample_ = lb_sample_0, lberror_ = lb_error_0
            };
            input_groups = new List<InputGroup> { group_0 };
        }

        private void btn_new_field_Click(object sender, EventArgs e)
        {
            input_groups.Add(ClassCreatePanel.Create(input_groups.Count));
            flowLayoutPanel1.Controls.Add(input_groups[input_groups.Count - 1].arr_);
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                for (int i = input_groups.Count; i < Convert.ToInt32(txt_numberField.Text); ++i)
                {
                    input_groups.Add(ClassCreatePanel.Create(i));
                    flowLayoutPanel1.Controls.Add(input_groups[input_groups.Count - 1].arr_);
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
