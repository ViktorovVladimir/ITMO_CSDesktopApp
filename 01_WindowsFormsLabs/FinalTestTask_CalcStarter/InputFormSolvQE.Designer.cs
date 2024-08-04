namespace SimpleCalculator
{
    partial class InputFormSolvQE
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
            this.textA = new System.Windows.Forms.TextBox();
            this.enterInputValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textA
            // 
            this.textA.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textA.Location = new System.Drawing.Point(137, 113);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(164, 75);
            this.textA.TabIndex = 0;
            // 
            // enterInputValues
            // 
            this.enterInputValues.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterInputValues.Location = new System.Drawing.Point(312, 275);
            this.enterInputValues.Name = "enterInputValues";
            this.enterInputValues.Size = new System.Drawing.Size(280, 85);
            this.enterInputValues.TabIndex = 3;
            this.enterInputValues.Text = "ОК";
            this.enterInputValues.UseVisualStyleBackColor = true;
            this.enterInputValues.Click += new System.EventHandler(this.enterInputValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "ax^2 + bx + c = 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 65);
            this.label2.TabIndex = 5;
            this.label2.Text = "a=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(330, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 65);
            this.label3.TabIndex = 7;
            this.label3.Text = "b=";
            // 
            // textB
            // 
            this.textB.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textB.Location = new System.Drawing.Point(436, 113);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(164, 75);
            this.textB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(632, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 65);
            this.label4.TabIndex = 9;
            this.label4.Text = "c=";
            // 
            // textC
            // 
            this.textC.Font = new System.Drawing.Font("Courier New", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textC.Location = new System.Drawing.Point(738, 110);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(164, 75);
            this.textC.TabIndex = 8;
            // 
            // InputFormSolvQE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterInputValues);
            this.Controls.Add(this.textA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InputFormSolvQE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter values";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Button enterInputValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textC;
    }
}