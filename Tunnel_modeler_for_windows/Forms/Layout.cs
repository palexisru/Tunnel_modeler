using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modeler.Tunnel.Windows.Forms
{
    public partial class Layout : UserControl
    {
        public Layout()
        {
            InitializeComponent();
        }

        private void Layout_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = e.Graphics;
            Brush b = Brushes.Black;
            Pen p = Pens.Black;
            g.DrawRectangle(p, 0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);
            g.DrawLine(p, 10, 10, 10, 20);
        }
    }
}
