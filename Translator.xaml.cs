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
    /// Логика взаимодействия для Translator.xaml
    /// </summary>
    public partial class Translator : Window
    {
        public Translator()
        {
            InitializeComponent();
        }

        Dictionary<string, string> Weather = new Dictionary<string, string>()
        {
            { "погода", "weather"},     
            { "туман","fog" },
            { "солнечно", "sunny"},            
            { "пасмурно", "cloudy"},
            { "ветрено", "wind" },           
            { "дождь","rain" },            
            { "молнии","tunder" },
            { "безветренная", "calm" },
            { "радуга","rainbow" },
            { "ураган", "shtorm"},


        };
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow a = new MainWindow();
            a.Show();
            this.Close();
        }
        string s = "";
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            s = TB1.Text;
        }
        private void Translatorrr(object sender, RoutedEventArgs e)
        {
            try
            {
                string w = s.ToLower();
                TB2.Text = Weather[w];
            }
            catch //catch не сработает ни разу в данном случае изза else
            {
                TB2.Text = "ERROR";
            }
        }
    }
}
