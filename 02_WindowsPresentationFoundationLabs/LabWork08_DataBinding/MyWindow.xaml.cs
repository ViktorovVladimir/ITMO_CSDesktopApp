using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ex01_CreatingDataBindingToCollectionObject
{
    /// <summary>
    /// Interaction logic for MyWindow.xaml
    /// </summary>
    public partial class MyWindow : Window
    {
        //--.
        private bool _close;
        //--.
        MainWindow wnd1 = null;

        public MyWindow()
        {
            InitializeComponent();
        }
        
        //--.
        private void Window_Closed(object sender, EventArgs e)
        {
            if (wnd1 != null)
                wnd1.myWin = null;
        }

        //--.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //--.
            if (_close) return;
            e.Cancel = true;
            Hide();
        }
    }
}
