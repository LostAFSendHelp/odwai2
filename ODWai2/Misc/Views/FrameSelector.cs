using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODWai2.Misc.Views
{
    public partial class FrameSelector : Form
    {
        private Rectangle _frame;

        public FrameSelector()
        {
            InitializeComponent();
            _frame = new Rectangle();
            ShowInTaskbar = false;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Opacity = 0.2f;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X)
            {
                Hide();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }
            _frame.Location = e.Location;
            _frame.Width = 0;
            _frame.Height = 0;
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left) { return; }
            _frame.Height = Math.Abs(e.Y - _frame.Y);
            _frame.Width = Math.Abs(e.X - _frame.X);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.FromArgb(50, 0, 0, 0));
            e.Graphics.FillRectangle(brush, _frame);

            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, _frame);
        }
    }
}
