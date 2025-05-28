
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsExercises
{
    public class nForm : TriangleForm
    {
        public nForm()
        {
            this.BackColor = Color.Blue;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Text = "Hello!!!";
                    btn.BackColor = Color.Brown;
                }
            }
        }
    }
}
