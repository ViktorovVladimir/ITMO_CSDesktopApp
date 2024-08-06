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

namespace Ex02_WorkingWithWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MyWindow myWin {  get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //--.
            Top = 25;
            Left = 25;
        }

        //--.
        private void New_Win_Click(object sender, RoutedEventArgs e)
        {   
            //--.
            if( myWin == null )
                myWin = new MyWindow();
            

            //--.
            var location = New_Win.PointFromScreen(new Point(0,0));
            myWin.Left = location.X + New_Win.Width;
            myWin.Top = location.Y;


            //--.
            myWin.Top = this.Top;
            myWin.Left = this.Left + this.Width;

            //--.
            myWin.Owner = this;
            //--.
            myWin.Show();

        }   
    }
}
