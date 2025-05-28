namespace WinPrint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            openFileDialog1 = new OpenFileDialog();
            button4 = new Button();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button1
            // 
            button1.Location = new Point(253, 211);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Page Setup";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(353, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(453, 211);
            button3.Name = "button3";
            button3.Size = new Size(94, 85);
            button3.TabIndex = 2;
            button3.Text = "Print Preview";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            // 
            // printDialog1
            // 
            printDialog1.AllowSomePages = true;
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            printPreviewDialog1.Load += printPreviewDialog1_Load;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Text Files | *.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button4
            // 
            button4.Location = new Point(310, 290);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Open File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private Button button2;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private OpenFileDialog openFileDialog1;
        private Button button4;
        private PrintPreviewDialog printPreviewDialog1;
        internal Button button3;
    }
}
