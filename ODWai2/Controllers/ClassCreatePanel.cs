using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODWai2.Misc;
using System.Windows.Forms;
using System.Drawing;

namespace ODWai2.Controllers
{
    class ClassCreatePanel
    {
        Misc.Views.NewInputSetView NewInputSetView;
        public ClassCreatePanel(Misc.Views.NewInputSetView form)
        {
            NewInputSetView = form;
        }



        public Panel Create(int s)
        {
            var p = new Panel { BackColor = Color.Azure, Size = NewInputSetView.pnl_0.Size, Name = "pnl_" + s.ToString() };
            p.Controls.Add(NewInputSetView.lbfield_[s] = new Label { Text = "Field", Name = "lb_fied", Location = NewInputSetView.lb_field_0.Location, Size = NewInputSetView.lb_field_0.Size, Font = NewInputSetView.lb_field_0.Font });
            p.Controls.Add(new Label { Text =":", Location = NewInputSetView.lb_2cham_1.Location, Size = NewInputSetView.lb_2cham_1.Size, Font = NewInputSetView.lb_2cham_1.Font });
            p.Controls.Add(NewInputSetView.field_[s] = new TextBox { Name = "txt_field_" + s.ToString(), Size = NewInputSetView.txt_field_0.Size, Location = NewInputSetView.txt_field_0.Location, Font = NewInputSetView.txt_field_0.Font });


            p.Controls.Add(NewInputSetView.lbassociated_[s] = new Label { Text = "Associated texts", Name = "lb_associal", Location = NewInputSetView.lb_associal_0.Location, Size = NewInputSetView.lb_associal_0.Size, Font = NewInputSetView.lb_associal_0.Font });
            p.Controls.Add(new Label { Text = ":", Location = NewInputSetView.lb_2cham_2.Location, Size = NewInputSetView.lb_2cham_2.Size, Font = NewInputSetView.lb_2cham_2.Font });
            p.Controls.Add(NewInputSetView.associated_[s] = new TextBox { Name = "txt_associalted_" + s.ToString(), Size = NewInputSetView.txt_associated_0.Size, Location = NewInputSetView.txt_associated_0.Location, Font = NewInputSetView.txt_associated_0.Font });


            p.Controls.Add(NewInputSetView.lbsample_[s] = new Label { Text = "Sample input", Name = "lb_sampleInput", Location = NewInputSetView.lb_sample_0.Location, Size = NewInputSetView.lb_sample_0.Size, Font = NewInputSetView.lb_sample_0.Font });
            p.Controls.Add(new Label { Text = ":", Location = NewInputSetView.lb_2cham_3.Location, Size = NewInputSetView.lb_2cham_3.Size, Font = NewInputSetView.lb_2cham_3.Font });
            p.Controls.Add(NewInputSetView.sample_[s] = new TextBox { Name = "txt_sampleInput_" + s.ToString(), Size = NewInputSetView.txt_sampleInput_0.Size, Location = NewInputSetView.txt_sampleInput_0.Location, Font = NewInputSetView.txt_sampleInput_0.Font });

            p.Controls.Add(NewInputSetView.lberror_[s] = new Label { Text = "Error input", Name = "lb_errorInput", Location = NewInputSetView.lb_error_0.Location, Size = NewInputSetView.lb_error_0.Size, Font = NewInputSetView.lb_sample_0.Font, AutoSize = true });
            p.Controls.Add(new Label { Text = ":", Location = NewInputSetView.lb_2cham_4.Location, Size = NewInputSetView.lb_2cham_4.Size, Font = NewInputSetView.lb_2cham_4.Font });
            p.Controls.Add(NewInputSetView.error_[s] = new TextBox { Name = "txt_errorInput_" + s.ToString(), Size = NewInputSetView.txt_errorInput_0.Size, Location = NewInputSetView.txt_errorInput_0.Location, Font = NewInputSetView.txt_errorInput_0.Font });

            p.Controls.Add(NewInputSetView.crr_[s] = new CheckBox { Name = "chbox_" + s.ToString(), Location = NewInputSetView.chbox_0.Location, Size = NewInputSetView.chbox_0.Size });

            return p;
        }
    }
}
