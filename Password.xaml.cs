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
    /// Логика взаимодействия для Password.xaml
    /// </summary>
    public partial class Password : Window
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        const string password = "qwerty123";
        string passwordUser = "";
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            passwordUser = Tb.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (passwordUser)
                {
                    case (password):
                        tb1.Text = "Password is right. ";
                        break;

                    default:
                        tb1.Text = "Error, repeat password";
                        Tb.Clear();

                        break;
                }
            }
            catch
            {
                tb1.Text = "Invalid";
            }
        }
    }
}
