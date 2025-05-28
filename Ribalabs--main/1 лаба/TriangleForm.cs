
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsExercises
{
    public class TriangleForm : Form
    {
        private Button closeButton;

        public TriangleForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Red;
            this.Load += new EventHandler(Form_Load);

            closeButton = new Button();
            closeButton.Text = "Close Form";
            closeButton.Location = new Point(0, 0);
            closeButton.Click += (s, e) => this.Close();
            this.Controls.Add(closeButton);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            GraphicsPath myPath = new GraphicsPath();
            myPath.AddPolygon(new Point[] { new Point(0, 0), new Point(0, this.Height), new Point(this.Width, 0) });
            this.Region = new Region(myPath);
        }
    }
}
