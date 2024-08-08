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

namespace Ex03_ImplementingRoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        //--.
        string nameFile = "username.txt";
        //--.
        bool isDataDirty = false;

        //--.
        public MyWindow myWin { get; set; }

        //--.
        public MainWindow()
        {
            InitializeComponent();

            //--.
            setBut.IsEnabled = false;
            retBut.IsEnabled = false;
        }

        //--.
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //--.
            if (this.isDataDirty)
            {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                //--.
                if (result == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //--.
        private void SetBut()
        {
            //--.
            System.IO.StreamWriter sw = null;

            //--.
            isDataDirty = false;

            //--.
            sw = new System.IO.StreamWriter(nameFile);
            sw.WriteLine(setText.Text);
            
            //--.
            if (sw != null)
                sw.Close();

            //--.
            retBut.IsEnabled = true;
        }

        //--.
        private void RetBut()
        {
            //--.
            System.IO.StreamReader sr = null;

            //--.
            using (sr = new System.IO.StreamReader(nameFile))
                retLabel.Content = "Greetings, dear " + sr.ReadToEnd();

            //--.
            if (sr != null)
                sr.Close();

            //--.
            setBut.IsEnabled = false;
            retBut.IsEnabled = false;
        }

        //--.
        private void setText_TextChanged(object sender, TextChangedEventArgs e)
        {
            //--.
            setBut.IsEnabled = true;

            //--.
            isDataDirty = true;
        }

        //--.
        private void funcShowNewWindow()
        {
            //--.
            if (myWin == null)
                myWin = new MyWindow();


            //--.
            var location = New_Win.PointFromScreen(new Point(0, 0));
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


        //--.
        private void Grid_Click(object sender, RoutedEventArgs e)
        {   
            //--.
            FrameworkElement feSource = e.Source as FrameworkElement;

            //--.
            try
            {
                //--.
                switch(feSource.Name)
                {
                    case "setBut":
                        SetBut();
                        break;
                    case "retBut":
                        RetBut();
                        break;
                    case "New_Win":
                        funcShowNewWindow();
                        break;
                }
                //--.
                e.Handled = true;
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }   
    }   
}
