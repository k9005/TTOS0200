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

namespace Lab_10._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double number;
        double number2;        
        double kurssi = 0;
        private void Amount1_TextChanged(object sender, TextChangedEventArgs e)
        {


            //else
            //{
            if (Combo1.Text == "Euro" && Combo2.Text == "Euro") kurssi = 1;
            else if (Combo1.Text == "Euro" && Combo2.Text == "Yhdysvallat USD") kurssi = 0.8997;
            else if (Combo1.Text == "Yhdysvallat USD" && Combo2.Text == "Euro") kurssi = 1.1003;
            else if (Combo1.Text == "Yhdysvallat USD" && Combo2.Text == "Yhdysvallat USD") kurssi = 1;
            else kurssi = 0;
            number = double.Parse(Amount1.Text);
                number2 = number * kurssi;
                Amount2.Text = number2.ToString("0.00");
            //}
        }

        private void Amount2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            
        }

        private void Combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        
    }
}
