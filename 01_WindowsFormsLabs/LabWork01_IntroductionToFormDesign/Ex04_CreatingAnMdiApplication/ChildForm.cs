﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_CreatingAnMdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        //--.
        private void toggleMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleMenuItem.Checked)
            {
                //--.
                toggleMenuItem.Checked = false;
                richChildTextBox.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                toggleMenuItem.Checked = true;
                richChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }

        }
    }
}
