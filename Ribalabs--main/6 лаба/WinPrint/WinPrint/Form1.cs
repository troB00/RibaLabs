namespace WinPrint
{
    public partial class Form1 : Form
    {
        string s;
        string[] strings;
        int ArrayCounter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            float MyLines = 0;
            float YPosition = 0;
            int Counter = 0;
            string CurrentLine;
            MyLines = e.MarginBounds.Height /
            this.Font.GetHeight(e.Graphics);
            while (Counter < MyLines && ArrayCounter <=
            strings.Length - 1)
            {
                CurrentLine = strings[ArrayCounter];
                YPosition = TopMargin + Counter *
                this.Font.GetHeight(e.Graphics);
                e.Graphics.DrawString(CurrentLine, this.Font,
                Brushes.Black, LeftMargin, YPosition, new StringFormat());
                Counter++;
                ArrayCounter++;
            }
            if (!(ArrayCounter >= strings.GetLength(0) - 1))
                e.HasMorePages = true;
            else
                e.HasMorePages = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.ShowDialog();
            Form2 aForm = new Form2();
            System.Windows.Forms.DialogResult aResult;
            aForm.printPreviewControl1.Document = printDocument1;
            aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
                printDocument1.Print();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult aResult;
            aResult = openFileDialog1.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader aReader =
                new System.IO.StreamReader(openFileDialog1.FileName);
                s = aReader.ReadToEnd();
                aReader.Close();
                strings = s.Split("\n");
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
        
        private void PrintPreviewToolStripMenuItemClick(object sender, EventArgs e)
        {
            Form2 aForm = new Form2();
            System.Windows.Forms.DialogResult aResult;
            aForm.printPreviewControl1.Document = printDocument1;
            aResult = aForm.ShowDialog();
            if (aResult == System.Windows.Forms.DialogResult.OK)
                printDocument1.Print();
        }
        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
