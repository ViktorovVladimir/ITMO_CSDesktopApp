namespace Ex02_WorkingWithLists
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberList = new System.Windows.Forms.CheckedListBox();
            this.peopleList = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.loadData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberList);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список участников";
            // 
            // memberList
            // 
            this.memberList.FormattingEnabled = true;
            this.memberList.Location = new System.Drawing.Point(20, 43);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(241, 96);
            this.memberList.TabIndex = 0;
            // 
            // peopleList
            // 
            this.peopleList.FormattingEnabled = true;
            this.peopleList.Items.AddRange(new object[] {
            "Medvedev Anton",
            "Smolianinov Artur",
            "Ivanov Roman",
            "Krasnov Pavel",
            "Freid Zigmund",
            "Neyman Dmitriy"});
            this.peopleList.Location = new System.Drawing.Point(386, 24);
            this.peopleList.Name = "peopleList";
            this.peopleList.Size = new System.Drawing.Size(249, 28);
            this.peopleList.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(381, 84);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(164, 40);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(381, 141);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(164, 39);
            this.del.TabIndex = 3;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(381, 197);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(164, 39);
            this.sort.TabIndex = 4;
            this.sort.Text = "Sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(641, 17);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(181, 40);
            this.loadData.TabIndex = 5;
            this.loadData.Text = "Загрузить данные";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.loadData_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 304);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.del);
            this.Controls.Add(this.add);
            this.Controls.Add(this.peopleList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.Text = "Работа со списками";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox memberList;
        private System.Windows.Forms.ComboBox peopleList;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button loadData;
    }
}

