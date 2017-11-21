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

namespace Lab_11._3
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
       

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void arvonta_Click(object sender, RoutedEventArgs e)
        {
            List<string> lines = new List<string>();
            int[] lottoNumbers = new int[7];
            int number;
            int luku;
            if (rivit.Text.Length > 0 & rivit.Text != "0" & int.TryParse(rivit.Text, out luku))
            {
                
            }
            Random rand = new Random();
            for (int a = 0; a < luku; a++)
            {
                for (int i = 0; i < lottoNumbers.Length; i++)
                {
                    do
                    {
                        number = rand.Next(1, 41);
                    }
                    while (lottoNumbers.Contains(number));
                    lottoNumbers[i] = number;
                }
            }
            
            lines.Add( String.Join(" ", lottoNumbers.Select(p => p.ToString()).ToArray()));
            tuloste.Text = String.Join(Environment.NewLine, lines);



        }
    }
}
