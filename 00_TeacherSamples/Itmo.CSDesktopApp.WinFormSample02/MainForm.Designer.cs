namespace Itmo.CSDesktopApp.WinFormSample02
{
    partial class MainForm
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
            this.executeTest = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // executeTest
            // 
            this.executeTest.Location = new System.Drawing.Point(122, 209);
            this.executeTest.Name = "executeTest";
            this.executeTest.Size = new System.Drawing.Size(378, 90);
            this.executeTest.TabIndex = 0;
            this.executeTest.Text = "Test";
            this.executeTest.UseVisualStyleBackColor = true;
            this.executeTest.Click += new System.EventHandler(this.executeTest_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(797, 209);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(51, 20);
            this.text.TabIndex = 1;
            this.text.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 675);
            this.Controls.Add(this.text);
            this.Controls.Add(this.executeTest);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeTest;
        private System.Windows.Forms.Label text;
    }
}

