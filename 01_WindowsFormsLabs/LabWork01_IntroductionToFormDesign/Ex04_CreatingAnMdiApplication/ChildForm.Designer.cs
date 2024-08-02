namespace Ex04_CreatingAnMdiApplication
{
    partial class ChildForm
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
            this.richChildTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStripChildWindow = new System.Windows.Forms.MenuStrip();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripChildWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // richChildTextBox
            // 
            this.richChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richChildTextBox.Location = new System.Drawing.Point(0, 33);
            this.richChildTextBox.Name = "richChildTextBox";
            this.richChildTextBox.Size = new System.Drawing.Size(800, 417);
            this.richChildTextBox.TabIndex = 0;
            this.richChildTextBox.Text = "";
            // 
            // menuStripChildWindow
            // 
            this.menuStripChildWindow.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripChildWindow.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripChildWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatMenuItem});
            this.menuStripChildWindow.Location = new System.Drawing.Point(0, 0);
            this.menuStripChildWindow.Name = "menuStripChildWindow";
            this.menuStripChildWindow.Size = new System.Drawing.Size(800, 33);
            this.menuStripChildWindow.TabIndex = 1;
            this.menuStripChildWindow.Text = "menuStrip1";
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleMenuItem});
            this.formatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.formatMenuItem.MergeIndex = 1;
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(85, 29);
            this.formatMenuItem.Text = "F&ormat";
            // 
            // toggleMenuItem
            // 
            this.toggleMenuItem.Name = "toggleMenuItem";
            this.toggleMenuItem.Size = new System.Drawing.Size(270, 34);
            this.toggleMenuItem.Text = "&Toggle Foreground";
            this.toggleMenuItem.Click += new System.EventHandler(this.toggleMenuItem_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richChildTextBox);
            this.Controls.Add(this.menuStripChildWindow);
            this.MainMenuStrip = this.menuStripChildWindow;
            this.Name = "ChildForm";
            this.Text = "Child Form";
            this.menuStripChildWindow.ResumeLayout(false);
            this.menuStripChildWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richChildTextBox;
        private System.Windows.Forms.MenuStrip menuStripChildWindow;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleMenuItem;
    }
}