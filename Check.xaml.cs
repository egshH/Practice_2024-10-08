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
    /// Логика взаимодействия для Check.xaml
    /// </summary>
    public partial class Check : Window
    {
        public Check()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }

        private void Num_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(Num.Text);
                if (0 <= num && num <= 14)
                {
                    nummm.Text = "[0-14]";
                }
                else if (15 <= num && num <= 35)
                {
                    nummm.Text = "[15-36]";
                }
                else if (36 <= num && num <= 50)
                {
                    nummm.Text = "[36-50]";
                }
                else if (50 <= num && num <= 100)
                {
                    nummm.Text = "[50-100]";
                }
                else
                {
                    nummm.Text = "renge is not define";
                }
            }
            catch
            {
                nummm.Text = "error";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
