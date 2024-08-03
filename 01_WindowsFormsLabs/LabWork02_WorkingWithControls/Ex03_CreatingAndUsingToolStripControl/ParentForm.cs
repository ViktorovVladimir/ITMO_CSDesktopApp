using System;
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
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
        }

        //--.
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            this.Close();
        }

        //--.
        private void cascadeWindowMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        //--.
        private void tileWindowMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        //--.
        private void newMenuItem_Click(object sender, EventArgs e)
        {
            //--.
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Text = newChild.Text + " " + (++openDocuments);
            newChild.Show();
        }
        
        //--.
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //--.
            switch (e.ClickedItem.Tag.ToString())
            {
                case "NewDoc":
                    /*
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Text = newChild.Text + " " + (++openDocuments);
                    newChild.Show();
                    */
                    newMenuItem_Click(sender, e);
                    break;
                case "Cascade":
                    /*
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    */
                    cascadeWindowMenuItem_Click(sender, e);
                    break ;
                case "Title":
                    /*
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    */
                    tileWindowMenuItem_Click(sender, e);
                    break;

            }
        }
    }
}
