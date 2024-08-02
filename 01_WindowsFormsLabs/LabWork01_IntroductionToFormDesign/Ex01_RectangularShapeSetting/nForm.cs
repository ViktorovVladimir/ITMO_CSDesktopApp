using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex01_RectangularShapeSetting
{
    public partial class nForm : Form
    {
        private bool bNclose = false;

        public nForm()
        {
            InitializeComponent();
        }

        //--.
        private void nForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //--.
            if( checkBoxClose.Checked )
                return;

            //--.
            if (bNclose)
                return;
            
            //--.
            e.Cancel = true;
            Hide();

        }
        
        //--.
        private void closeForm_Click(object sender, EventArgs e)
        {
            //--.
            Close();
        }

        //--.
        public new void Close()
        {
            bNclose = true;
            base.Close();
        }

        private void nForm_Load(object sender, EventArgs e)
        {

        }
    }
}
