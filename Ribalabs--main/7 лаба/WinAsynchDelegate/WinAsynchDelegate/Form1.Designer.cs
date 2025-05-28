namespace WinAsynchDelegate
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Second to sleep";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Progress";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(133, 42);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(125, 29);
            progressBar1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(264, 9);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 39);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 91);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
    }
}
