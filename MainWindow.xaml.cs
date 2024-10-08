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

namespace PracticeTask2_2024_10_08
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Translator(object sender, RoutedEventArgs e)
        {
            Translator a = new Translator();
            a.Show();
            this.Close();
        }

        private void Calculator(object sender, RoutedEventArgs e)
        {
            Calculator b = new Calculator();
            b.Show();
            this.Close();
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            Check c = new Check();
            c.Show();
            this.Close();
        }

        private void Password(object sender, RoutedEventArgs e)
        {
            Password d = new Password();
            d.Show();
            this.Close();
        }
    }
}
