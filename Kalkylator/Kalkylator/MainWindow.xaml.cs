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

namespace Kalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Zero(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "0";
            this.Siffror.Text += input;
        }
        private void Button_One(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "1";
            this.Siffror.Text += input;
        }
        private void Button_Two(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "2";
            this.Siffror.Text += input;
        }
        private void Button_Three(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "3";
            this.Siffror.Text += input;
        }
        private void Button_Four(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "4";
            this.Siffror.Text += input;
        }
        private void Button_Five(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "5";
            this.Siffror.Text += input;
        }
        private void Button_Six(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "6";
            this.Siffror.Text += input;
        }
        private void Button_Seven(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "7";
            this.Siffror.Text += input;
        }
        private void Button_Eight(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "8";
            this.Siffror.Text += input;
        }
        private void Button_Nine(object sender, RoutedEventArgs e)
        {
            this.Siffror.Text = "";
            input += "9";
            this.Siffror.Text += input;
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;

        }
        private void Button_Subtract(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;

        }
        private void Button_Multiply(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;

        }
        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;

        }
        private void Button_Dot(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '.';
            input = string.Empty;

        }
        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            Siffror.Text = String.Empty;
        }
        private void Button_Sum(object sender, RoutedEventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                result = num1 + num2;
                Siffror.Text = result.ToString();
            }
            else if(operation == '-')
            {
                result = num1 - num2;
                Siffror.Text = result.ToString();
            }
            else if(operation == '*')
            {
                result = num1 * num2;
                Siffror.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if(num2!= 0)
                {
                    result = num1 / num2;
                    Siffror.Text = result.ToString();
                }
                else
                {
                    Siffror.Text = "DIV/Zero";
                }
            }
        }

    }
}
