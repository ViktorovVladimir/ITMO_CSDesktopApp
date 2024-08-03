using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ex02_WorkingWithLists
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //--.
        private void add_Click(object sender, EventArgs e)
        {
            //--.
            if( peopleList.Text.Length != 0 )
            {
                memberList.Items.Add(peopleList.Text);
            }
            else
            {
                MessageBox.Show("Please select an item from the list or enter a new one");
            }
        }

        //--.
        private void del_Click(object sender, EventArgs e)
        {
            //--.
            while(memberList.CheckedIndices.Count > 0) 
            {
                memberList.Items.RemoveAt( memberList.CheckedIndices[0] );
            }
        }

        //--.
        private void sort_Click(object sender, EventArgs e)
        {
            //--.
            memberList.Sorted = true;
        }

        //--.
        private void loadData_Click(object sender, EventArgs e)
        {
            //--.
            peopleList.Items.Clear();
            //--.
            FileStream fStream = new FileStream("..\\..\\XMLData.xml", FileMode.Open, 
                                                        FileAccess.Read, FileShare.ReadWrite);

            //--.
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(fStream);

            //--.
            for( int i = 0; i < xmlDoc.DocumentElement.ChildNodes.Count; i++ )
            {
                peopleList.Items.Add(xmlDoc.DocumentElement.ChildNodes[i].InnerText);        
            }   
            
            //--.
            fStream.Close();

        }
    }
}
