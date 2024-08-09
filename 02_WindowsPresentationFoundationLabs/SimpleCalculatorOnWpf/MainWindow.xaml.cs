using Calculator;
using SimpleCalculatorOnWpf.Properties;
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

namespace SimpleCalculatorOnWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";


        public MainWindow()
        {
            InitializeComponent();
        }

        //--.
        private void Grid_Click(object sender, RoutedEventArgs e)
        {

            //--.
            FrameworkElement feSource = e.Source as FrameworkElement;
            
            //--.
            switch ( feSource.Name )
            {
                case "KeyZero":
                    OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
                    break;
                case "KeyOne":
                    OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
                    break;
                case "KeyTwo":
                    OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
                    break;
                case "KeyThree":
                    OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
                    break;
                case "KeyFour":
                    OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
                    break;
                case "KeyFive":
                    OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
                    break;
                case "KeySix":
                    OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
                    break;
                case "KeySeven":
                    OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
                    break;
                case "KeyEight":
                    OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
                    break;
                case "KeyNine":
                    OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
                    break;
                case "KeyDivide":
                    CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
                    break;
                case "KeyMultiply":
                    CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
                    break;
                case "KeyMinus":
                    CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
                    break;
                case "KeyPlus":
                    CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
                    break;
                case "KeySign":
                    OutputDisplay.Text = CalcEngine.CalcSign();
                    break;
                case "KeyClear":
                    CalcEngine.CalcReset();
                    OutputDisplay.Text = "0";
                    break;
                case "KeyExit":
                    this.Close();
                    break;
                case "KeyDate":
                    OutputDisplay.Text = CalcEngine.GetDate();
                    CalcEngine.CalcReset();
                    break;
                case "KeyEqual":
                    OutputDisplay.Text = CalcEngine.CalcEqual();
                    CalcEngine.CalcReset();
                    break;


            }
            //--.
            e.Handled = true;
        }
    }
}
