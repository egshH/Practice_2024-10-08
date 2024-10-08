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

namespace PracticeTask2_2024_10_08
{
    /// <summary>
    /// Логика взаимодействия для Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();

        }
        Random R = new Random();



        string a;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            a = tbb.Text;
        }

        double operand1;
        double operand2;
        private void RNUM(object sender, RoutedEventArgs e)
        {
            Tb1.Text = Convert.ToString(R.Next(-99999, 99999));
            operand1 = Convert.ToInt32(Tb1.Text);
            Tb2.Text = Convert.ToString(R.Next(-99999, 99999));
            operand2 = Convert.ToInt32(Tb2.Text);
        }
        double rez = 0;
        private void Sch(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (a)
                {
                    case "+":
                        rez = operand1 + operand2;
                        resultat.Text = Convert.ToString(rez);
                        break;
                    case "-":
                        rez = operand2 - operand1;
                        resultat.Text = Convert.ToString(rez);
                        break;
                    case "*":
                        rez = operand1 * operand2;
                        resultat.Text = Convert.ToString(rez);
                        break;
                    case "/":
                        rez = operand2 / operand1;
                        resultat.Text = Convert.ToString(rez);
                        break;
                    default:
                        resultat.Text = "ERROR!!!!!!!!!!!";
                        break;
                }
            }
            catch //catch не сработает ни разу в данном случае изза default
            {
                resultat.Text = "ERROR";
            }
        }
    }
}
