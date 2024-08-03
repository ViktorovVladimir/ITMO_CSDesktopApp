namespace Ex04_CreatingAnMdiApplication
{
    partial class ParentForm
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
            this.MdiMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spWin = new System.Windows.Forms.ToolStripStatusLabel();
            this.spData = new System.Windows.Forms.ToolStripStatusLabel();
            this.MdiMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiMenu
            // 
            this.MdiMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MdiMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MdiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.windowMenuItem});
            this.MdiMenu.Location = new System.Drawing.Point(0, 0);
            this.MdiMenu.MdiWindowListItem = this.windowMenuItem;
            this.MdiMenu.Name = "MdiMenu";
            this.MdiMenu.Size = new System.Drawing.Size(428, 36);
            this.MdiMenu.TabIndex = 1;
            this.MdiMenu.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileMenuItem.Text = "&File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(149, 34);
            this.newMenuItem.Text = "&New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(149, 34);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // windowMenuItem
            // 
            this.windowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeWindowMenuItem,
            this.tileWindowMenuItem});
            this.windowMenuItem.Name = "windowMenuItem";
            this.windowMenuItem.Size = new System.Drawing.Size(94, 32);
            this.windowMenuItem.Text = "&Window";
            // 
            // cascadeWindowMenuItem
            // 
            this.cascadeWindowMenuItem.Name = "cascadeWindowMenuItem";
            this.cascadeWindowMenuItem.Size = new System.Drawing.Size(179, 34);
            this.cascadeWindowMenuItem.Text = "&Cascade";
            this.cascadeWindowMenuItem.Click += new System.EventHandler(this.cascadeWindowMenuItem_Click);
            // 
            // tileWindowMenuItem
            // 
            this.tileWindowMenuItem.Name = "tileWindowMenuItem";
            this.tileWindowMenuItem.Size = new System.Drawing.Size(179, 34);
            this.tileWindowMenuItem.Text = "&Tile";
            this.tileWindowMenuItem.Click += new System.EventHandler(this.tileWindowMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spWin,
            this.spData});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 32);
            this.statusStrip1.TabIndex = 3;
            // 
            // spWin
            // 
            this.spWin.Name = "spWin";
            this.spWin.Size = new System.Drawing.Size(60, 25);
            this.spWin.Text = "Status";
            // 
            // spData
            // 
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(49, 25);
            this.spData.Text = "Data";
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 294);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MdiMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiMenu;
            this.Name = "ParentForm";
            this.Text = "Parent Form";
            this.MdiMenu.ResumeLayout(false);
            this.MdiMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileWindowMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel spWin;
        private System.Windows.Forms.ToolStripStatusLabel spData;
    }
}

