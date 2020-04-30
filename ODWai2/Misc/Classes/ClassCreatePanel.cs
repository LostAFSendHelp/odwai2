using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODWai2.Misc;
using System.Windows.Forms;
using System.Drawing;
using ODWai2.Misc.Classes;

namespace ODWai2.Controllers
{
    class ClassCreatePanel
    {
        Misc.Views.NewInputSetView new_input_set_view;
        public ClassCreatePanel(Misc.Views.NewInputSetView form)
        {
            new_input_set_view = form;
        }

        public InputGroup Create(int s)
        {
            var p = new Panel { BackColor = Color.Azure, Size = new_input_set_view.pnl_0.Size, Name = "pnl_" + s.ToString() };
            Label _lbfield = null, _lb_length = null, _lb_must_have = null, _lb_must_not_have = null, _lb_associated = null;
            TextBox _txt_field = null, _txt_associated = null, _txt_length = null, _txt_must_have = null, _txt_must_not_have = null;
            CheckBox crr = new CheckBox();

            add_stuff(ref _lbfield, ref _txt_field, "Field", "lb_field", "txt_field_" + s.ToString(), new_input_set_view.lb_2cham_1.Location, new_input_set_view.lb_2cham_1.Size, new_input_set_view.lb_2cham_1.Font, new_input_set_view.lb_field_0, new_input_set_view.txt_field_0);
            add_stuff(ref _lb_associated, ref _txt_associated, "Associated texts", "lb_associated", "txt_associated_" + s.ToString(), new_input_set_view.lb_2cham_2.Location, new_input_set_view.lb_2cham_2.Size, new_input_set_view.lb_2cham_2.Font, new_input_set_view.lb_associal_0, new_input_set_view.txt_associated_0);
            add_stuff(ref _lb_length, ref _txt_length, "Length", "lb_length", "lb_length_" + s.ToString(), new_input_set_view.lb_2cham_3.Location, new_input_set_view.lb_2cham_3.Size, new_input_set_view.lb_2cham_3.Font, new_input_set_view.lb_sample_0, new_input_set_view.txt_length_0);
            add_stuff(ref _lb_must_have, ref _txt_must_have, "Must have", "lb_must_have", "txt_must_have_" + s.ToString(), new_input_set_view.lb_2cham_4.Location, new_input_set_view.lb_2cham_4.Size, new_input_set_view.lb_2cham_4.Font, new_input_set_view.lb_must_have_0, new_input_set_view.txt_must_have_0);
            add_stuff(ref _lb_must_not_have, ref _txt_must_not_have, "Must not have", "lb_must_not_have", "txt_must_not_have_" + s.ToString(), new_input_set_view.lb_2cham_5.Location, new_input_set_view.lb_2cham_5.Size, new_input_set_view.lb_2cham_5.Font, new_input_set_view.lb_must_not_have_0, new_input_set_view.txt_must_not_have_0);
            p.Controls.Add(crr = new CheckBox { Name = "chbox_" + s.ToString(), Location = new_input_set_view.chbox_0.Location, Size = new_input_set_view.chbox_0.Size });

            void add_stuff(ref Label lb_field, ref TextBox txt_field, string label_text, string label_name, string txt_name, Point colon_location, Size colon_size, Font colon_font, Label label_ref, TextBox txt_ref)
            {
                p.Controls.Add(lb_field = new Label { Text = label_text, Name = label_name, Location =label_ref.Location, Size = label_ref.Size, Font = label_ref.Font, AutoSize = true });
                p.Controls.Add(new Label { Text = ":", Location = colon_location, Size = colon_size, Font = colon_font });
                p.Controls.Add(txt_field = new TextBox { Name = txt_name + s.ToString(), Size = txt_ref.Size, Location = txt_ref.Location, Font = txt_ref.Font });
            }

            return new InputGroup() {
                arr_ = p, crr_ = crr, lb_field_ = _lbfield, must_have_ = _txt_must_have,
                associated_ = _txt_associated, length_ = _txt_length,
                field_ = _txt_field, lb_associated_ = _lb_associated,
                lb_must_not_have_ = _lb_must_have, lb_length_ = _lb_length
            };
        }
    }
}
