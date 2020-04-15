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
        private const int MIN_SIZE = 300;
        private Action<int, int, int, int> _on_exit;

        public FrameSelector(Action<int, int, int, int> on_exit)
        {
            InitializeComponent();
            _initialize();
            ShowInTaskbar = false;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Opacity = 0.2f;

            _on_exit = on_exit;
            _on_exit(_frame.X, _frame.Y, _frame.Width, _frame.Height);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.X) { return; }
            if (_frame.Width < MIN_SIZE || _frame.Height < MIN_SIZE)
            {
                MessageBox.Show("Please select a bigger region.\n Mininum length is " + MIN_SIZE + "px for each dimension");
                return;
            }
            else
            {
                if (_on_exit != null) { _on_exit(_frame.X, _frame.Y, _frame.Width, _frame.Height); }
                Close();
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

        private void _initialize()
        {
            int width = Screen.PrimaryScreen.Bounds.Width / 2;
            int height = Screen.PrimaryScreen.Bounds.Height;
            _frame = new Rectangle(0, 0, width, height);
        }
    }
}
