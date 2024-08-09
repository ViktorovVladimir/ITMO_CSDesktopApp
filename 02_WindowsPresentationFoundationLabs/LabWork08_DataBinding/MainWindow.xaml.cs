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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ex01_CreatingDataBindingToCollectionObject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyWindow myWin { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //--.
            if (myWin == null)
                myWin = new MyWindow();


            //--.
            var location = ButNewWin.PointFromScreen(new Point(0, 0));
            myWin.Left = location.X + ButNewWin.Width;
            myWin.Top = location.Y;


            //--.
            myWin.Top = this.Top;
            myWin.Left = this.Left + this.Width;

            //--.
            myWin.Owner = this;
            //--.
            myWin.Show();
        }

        //--.
        public void selectLBItem(int index)
        {
            if( index >= 0 && index < ListBox1.Items.Count )
            {
                ListBox1.SelectedIndex = index;
                ListBox1.ScrollIntoView(ListBox1.SelectedItem);
            }   
        }

    }
}
