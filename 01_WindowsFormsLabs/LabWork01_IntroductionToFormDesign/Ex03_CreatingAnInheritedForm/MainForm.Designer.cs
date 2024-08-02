namespace Ex03_CreatingAnInheritedForm
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
            this.closeForm = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.calcSupertest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Location = new System.Drawing.Point(250, 210);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(232, 79);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = "Close Form";
            this.closeForm.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(250, 387);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(140, 59);
            this.test.TabIndex = 1;
            this.test.Text = "calc test";
            this.test.UseVisualStyleBackColor = true;
            // 
            // calcSupertest
            // 
            this.calcSupertest.Location = new System.Drawing.Point(688, 539);
            this.calcSupertest.Name = "calcSupertest";
            this.calcSupertest.Size = new System.Drawing.Size(136, 46);
            this.calcSupertest.TabIndex = 2;
            this.calcSupertest.Text = "calc supertest";
            this.calcSupertest.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 655);
            this.Controls.Add(this.calcSupertest);
            this.Controls.Add(this.test);
            this.Controls.Add(this.closeForm);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button closeForm;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button calcSupertest;
    }
}

