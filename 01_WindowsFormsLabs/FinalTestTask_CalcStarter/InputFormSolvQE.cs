using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class InputFormSolvQE : Form
    {
        public string valueA { get; private set; }
        public string valueB { get; private set; }
        public string valueC { get; private set; }

        public InputFormSolvQE()
        {
            InitializeComponent();

            //--.
            textA.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textB.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            textC.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
        }

        //--.
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {   
            TextBox textBox = (TextBox)sender;      //sender as TexBox

            //--.
            if( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' )
                e.Handled = true;   //cancel entry

            //--. allow only one minus sign and only at the beginning of the line
            if (  e.KeyChar == '-' && textBox.SelectionStart != 0 )
                e.Handled = true;   //cancel entry

        }

        //--.
        private void enterInputValues_Click(object sender, EventArgs e)
        {
            //--.
            valueA = textA.Text;
            valueB = textB.Text;
            valueC = textC.Text;
            //--.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
