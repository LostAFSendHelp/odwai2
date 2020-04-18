using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Misc.Classes;

namespace ODWai2.Misc.Views
{
    public partial class LoadingProgressView : SubView
    {
        public LoadingProgressView(string progress = "")
        {
            InitializeComponent();
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            UseWaitCursor = true;

            lbl_progress.Text = progress;
        }

        public void set_progress(string progress)
        {
            lbl_progress.Text = progress;
            Refresh();
        }
    }
}
