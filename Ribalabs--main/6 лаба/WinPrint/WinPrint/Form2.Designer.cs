namespace WinPrint
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            checkBox1 = new CheckBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            printPreviewControl1 = new PrintPreviewControl();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button1);
            splitContainer1.Panel1.Controls.Add(checkBox1);
            splitContainer1.Panel1.Controls.Add(numericUpDown3);
            splitContainer1.Panel1.Controls.Add(numericUpDown2);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(printPreviewControl1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(24, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(138, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "AntiAlias";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown3.Location = new Point(98, 110);
            numericUpDown3.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(150, 27);
            numericUpDown3.TabIndex = 5;
            numericUpDown3.Value = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(98, 62);
            numericUpDown2.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 23);
            numericUpDown1.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // printPreviewControl1
            // 
            printPreviewControl1.Dock = DockStyle.Fill;
            printPreviewControl1.Location = new Point(0, 0);
            printPreviewControl1.Name = "printPreviewControl1";
            printPreviewControl1.Size = new Size(530, 450);
            printPreviewControl1.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form2";
            Text = "Form2";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        internal PrintPreviewControl printPreviewControl1;
    }
}