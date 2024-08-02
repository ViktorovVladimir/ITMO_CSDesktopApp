namespace Ex01_HandlingClickAndMouseMoveEvents
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
            this.btnyes = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.btnno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(28, 49);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(128, 35);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Yes";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(24, 18);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(246, 20);
            this.text.TabIndex = 1;
            this.text.Text = "Are you satisfied with your salary?";
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(28, 91);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(128, 35);
            this.btnno.TabIndex = 2;
            this.btnno.TabStop = false;
            this.btnno.Text = "No";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnno_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 140);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.text);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "WinQuestion: urgent question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button btnno;
    }
}

