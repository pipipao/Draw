using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color getColor() {
            Random r = new Random();
            return Color.FromArgb(r.Next(256),r.Next(256),r.Next(256));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x0 = this.Width / 2;
            int y0 = this.Height / 2;
            for (int r=1;r<this.Width/2;r++) {
                g.DrawEllipse(new Pen(getColor(),1),x0-r,y0-r,r*2,r*2);
            }
            g.Dispose();
        }
    }
}
