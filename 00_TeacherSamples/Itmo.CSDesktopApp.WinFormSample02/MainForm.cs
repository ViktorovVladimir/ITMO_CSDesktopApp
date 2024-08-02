using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itmo.CSDesktopApp.WinFormSample02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //--.
        private void executeTest_Click(object sender, EventArgs e)
        {
            //--.
            text.Text = "test";
            //--.
            this.Text = "test";
            //--.
            MessageBox.Show("Test");
        }

        //--.
        private void MainForm_Load(object sender, EventArgs e)
        {
            /*
            this.Text = "Стартовая форма";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Size = new Size(300, 200);
            this.Opacity = 0.8;
            this.TopMost = true;
            MessageBox.Show("Посмотрите на свойства формы", "Внимание!!!");
            */
        }
    }
}
