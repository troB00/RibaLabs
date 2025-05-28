namespace WinLanguage
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            commandOneToolStripMenuItem = new ToolStripMenuItem();
            commandTwoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { commandOneToolStripMenuItem, commandTwoToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // commandOneToolStripMenuItem
            // 
            resources.ApplyResources(commandOneToolStripMenuItem, "commandOneToolStripMenuItem");
            commandOneToolStripMenuItem.Name = "commandOneToolStripMenuItem";
            // 
            // commandTwoToolStripMenuItem
            // 
            resources.ApplyResources(commandTwoToolStripMenuItem, "commandTwoToolStripMenuItem");
            commandTwoToolStripMenuItem.Name = "commandTwoToolStripMenuItem";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commandOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandTwoToolStripMenuItem;
    }
}