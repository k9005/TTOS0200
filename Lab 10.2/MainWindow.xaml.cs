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
        private void Amount1_TextChanged(object sender, TextChangedEventArgs e)
        {

            double o = 0;
            if (!double.TryParse(Amount1.Text, out o))
            {
                Amount2.Text = 0.ToString("0.00");
            }
            else
            {
                number = double.Parse(Amount1.Text);
                number2 = number * 0.8997;
                Amount2.Text = number2.ToString("0.00");
            }
        }

        private void Amount2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
