
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "Trey Research";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 200);
            this.Opacity = 0.75;

            Button button1 = new Button() { Text = "Border Style", Location = new Point(10, 10), Anchor = AnchorStyles.Top | AnchorStyles.Left };
            Button button2 = new Button() { Text = "Resize", Location = new Point(10, 50) };
            Button button3 = new Button() { Text = "Opacity", Location = new Point(10, 90) };

            button1.Click += (s, eArgs) => { this.FormBorderStyle = FormBorderStyle.Sizable; };
            button2.Click += (s, eArgs) => { this.Size = new Size(300, 500); };
            button3.Click += (s, eArgs) => { this.Opacity = 1; };

            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
        }
    }
}
