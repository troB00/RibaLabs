namespace Lab10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFillListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFillGrid;
        private System.Windows.Forms.Button btnUpdateDb;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnApplyView;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button btnBindControls;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnFillListBox = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFillGrid = new System.Windows.Forms.Button();
            this.btnUpdateDb = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnApplyView = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.btnBindControls = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Size = new System.Drawing.Size(200, 100);
 
            this.btnFillListBox.Location = new System.Drawing.Point(12, 120);
            this.btnFillListBox.Size = new System.Drawing.Size(200, 23);
            this.btnFillListBox.Text = "Заполнить ListBox (DataReader)";
            this.btnFillListBox.Click += new System.EventHandler(this.btnFillListBox_Click);
 
            this.dataGridView1.Location = new System.Drawing.Point(220, 12);
            this.dataGridView1.Size = new System.Drawing.Size(400, 100);
 
            this.btnFillGrid.Location = new System.Drawing.Point(220, 120);
            this.btnFillGrid.Size = new System.Drawing.Size(120, 23);
            this.btnFillGrid.Text = "Заполнить Grid (DataSet)";
            this.btnFillGrid.Click += new System.EventHandler(this.btnFillGrid_Click);
 
            this.btnUpdateDb.Location = new System.Drawing.Point(350, 120);
            this.btnUpdateDb.Size = new System.Drawing.Size(120, 23);
            this.btnUpdateDb.Text = "Обновить БД";
            this.btnUpdateDb.Click += new System.EventHandler(this.btnUpdateDb_Click);
 
            this.listBox2.Location = new System.Drawing.Point(12, 160);
            this.listBox2.Size = new System.Drawing.Size(200, 100);

            this.btnApplyView.Location = new System.Drawing.Point(12, 270);
            this.btnApplyView.Size = new System.Drawing.Size(200, 23);
            this.btnApplyView.Text = "Применить DataView";
            this.btnApplyView.Click += new System.EventHandler(this.btnApplyView_Click);

            this.textBoxId.Location = new System.Drawing.Point(220, 160);
            this.textBoxId.Size = new System.Drawing.Size(100, 23);

            this.textBoxName.Location = new System.Drawing.Point(220, 190);
            this.textBoxName.Size = new System.Drawing.Size(100, 23);

            this.textBoxAge.Location = new System.Drawing.Point(220, 220);
            this.textBoxAge.Size = new System.Drawing.Size(100, 23);

            this.btnBindControls.Location = new System.Drawing.Point(220, 250);
            this.btnBindControls.Size = new System.Drawing.Size(100, 23);
            this.btnBindControls.Text = "Привязать";
            this.btnBindControls.Click += new System.EventHandler(this.btnBindControls_Click);

            this.comboBox1.Location = new System.Drawing.Point(330, 160);
            this.comboBox1.Size = new System.Drawing.Size(140, 23);

            this.btnNext.Location = new System.Drawing.Point(330, 190);
            this.btnNext.Size = new System.Drawing.Size(60, 23);
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
 
            this.btnPrev.Location = new System.Drawing.Point(410, 190);
            this.btnPrev.Size = new System.Drawing.Size(60, 23);
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnFillListBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFillGrid);
            this.Controls.Add(this.btnUpdateDb);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnApplyView);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.btnBindControls);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Text = "Lab10: Работа с БД";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}