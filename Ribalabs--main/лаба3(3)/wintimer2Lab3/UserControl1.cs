using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wintimer2Lab3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics g = pe.Graphics;

            
            g.FillRectangle(Brushes.Blue, 0, 0, this.Width, this.Height);

            
            string time = DateTime.Now.ToLongTimeString();

           
            using (Brush textBrush = new SolidBrush(Color.White))
            {
                g.DrawString(time, this.Font, textBrush, 10, 10);
            }
        }
    }
}
