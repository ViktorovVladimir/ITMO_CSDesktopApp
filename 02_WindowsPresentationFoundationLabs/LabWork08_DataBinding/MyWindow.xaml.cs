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
        //private bool _close;
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
            //if (_close) 
            //    return;
            e.Cancel = true;
            Hide();
        }

        private void ListBox2_Selected(object sender, RoutedEventArgs e)
        {


            //wnd1.selectItem(2);
        }

        private void ListBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //--.
            //string curItem = ListBox2.SelectedItem.ToString();
            //--.
            int index = ListBox2.SelectedIndex;

            MainWindow w = (MainWindow)this.Owner;
            w.selectLBItem(index);

        }

        //--.
        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            if( mainWindow != null && ListBox2.SelectedItem is Student st) 
            {
                mainWindow.updateTextBlock(st.StudentName, commentText.Text.ToString());
            }
        }   
    }
}
