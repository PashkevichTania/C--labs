using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTimer2
{
    public partial class UserControlTimer2 : UserControl
    {
        public UserControlTimer2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);

            e.Graphics.DrawString(DateTime.Now.ToLongTimeString(),
            this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }
    }
}
