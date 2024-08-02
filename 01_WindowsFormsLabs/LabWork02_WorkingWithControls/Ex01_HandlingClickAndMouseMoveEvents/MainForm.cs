using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_HandlingClickAndMouseMoveEvents
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //--.
        private void btnyes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("We have no doubt that you think so!");
        }

        //--
        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            //--.
            btnno.Top -= e.Y;
            btnno.Left += e.X;
            if (btnno.Top < -10 || btnno.Top > 100)
                btnno.Top = 60;
            if (btnno.Top < -80 || btnno.Top > 250)
                btnno.Left = 120;

        }
    }
}
