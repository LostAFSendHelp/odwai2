using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODWai2.Misc;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace ODWai2.Controllers
{
    public class ClassCreatePanel
    {
        Misc.NewInputSetView NewInputSetView;
        public ClassCreatePanel(Misc.NewInputSetView form)
        {
            NewInputSetView = form;
        }


        public Panel Create(int s)
        {
            var p = new Panel { BackColor = Color.Azure, Size = NewInputSetView.pnl_1.Size, Name = "pnl_"+ s.ToString() };
            p.Controls.Add(new Label { Text = "Field:" + s.ToString(), Name = "lb_fied", Location = NewInputSetView.lb_field1.Location, Size = NewInputSetView.lb_field1.Size, Font = NewInputSetView.lb_field1.Font });
            p.Controls.Add(new TextBox { Name = "txt_field_" + s.ToString(), Size = NewInputSetView.txt_field_1.Size, Location = NewInputSetView.txt_field_1.Location, Font = NewInputSetView.txt_field_1.Font });


            p.Controls.Add(new Label { Text = "Associated texts : ", Name = "lb_associal", Location = NewInputSetView.lb_associal1.Location, Size = NewInputSetView.lb_associal1.Size, Font = NewInputSetView.lb_associal1.Font });
            p.Controls.Add(new TextBox { Name = "txt_associalted_" + s.ToString(), Size = NewInputSetView.txt_associated_1.Size, Location = NewInputSetView.txt_associated_1.Location, Font = NewInputSetView.txt_associated_1.Font });


            p.Controls.Add(new Label { Text = "Sample input : ", Name = "lb_sampleInput", Location = NewInputSetView.lb_input1.Location, Size = NewInputSetView.lb_input1.Size, Font = NewInputSetView.lb_input1.Font });
            p.Controls.Add(new TextBox { Name = "txt_sampleInput_" + s.ToString(), Size = NewInputSetView.txt_sampleInput_1.Size, Location = NewInputSetView.txt_sampleInput_1.Location, Font = NewInputSetView.txt_sampleInput_1.Font });

            p.Controls.Add(new Label { Text = "Error input :", Name = "lb_errorInput", Location = NewInputSetView.lb_error.Location, Size = NewInputSetView.lb_input1.Size, Font =  NewInputSetView.lb_input1.Font });
            p.Controls.Add(new TextBox { Name = "txt_errorInput_" + s.ToString(), Size = NewInputSetView.txt_errorInput_1.Size, Location = NewInputSetView.txt_errorInput_1.Location, Font = NewInputSetView.txt_errorInput_1.Font });

            return p;
        }

    }
}
