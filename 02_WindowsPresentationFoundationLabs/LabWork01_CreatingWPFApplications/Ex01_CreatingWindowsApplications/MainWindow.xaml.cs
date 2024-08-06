﻿using System;
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

namespace Ex01_CreatingWindowsApplications
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        //--.
        bool isDataDirty = false;

        //--.
        public MainWindow()
        {
            InitializeComponent();

            //--.
            lbl.Content = "Good afternoon";

            //--.
            setBut.IsEnabled = false;
            retBut.IsEnabled = false;
        }

        //--.
        private void setBut_Click(object sender, RoutedEventArgs e)
        {
            //--.
            System.IO.StreamWriter sw = null;

            //--.
            isDataDirty = false;

            //--.
            try
            {
                sw = new System.IO.StreamWriter("username.txt");
                sw.WriteLine(setText.Text);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sw != null)
                    sw.Close();

                //--.
                retBut.IsEnabled = true;
            }
        }

        //--.
        private void retBut_Click(object sender, RoutedEventArgs e)
        {   
            //--.
            System.IO.StreamReader sr = null;
            
            //--.
            try
            {
                using (sr = new System.IO.StreamReader("username.txt")) 
                    retLabel.Content = "Greetings, dear " + sr.ReadToEnd();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(sr != null)
                    sr.Close();

                //--.
                setBut.IsEnabled = false;
                retBut.IsEnabled = false;
            }
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
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {   
            //--.
            if( this.isDataDirty )
            {
                string msg = "Данные были изменены, но не сохранены!\n Закрыть окно без сохранения?";
                MessageBoxResult result = MessageBox.Show(msg, "Контроль данных", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                //--.
                if( result == MessageBoxResult.No ) 
                { 
                    e.Cancel = true;
                }
            }   
        }
        
        //--.
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
