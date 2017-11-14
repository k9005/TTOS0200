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

namespace Lab_10._3
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

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double number = 0;
            if (!double.TryParse(ikkunankorkeus.Text, out number)) { }
            else if (!double.TryParse(ikkunanleveys.Text, out number)) { }
            else if (!double.TryParse(karminleveys.Text, out number)) { }



            else
            {

                if (30 < double.Parse(ikkunankorkeus.Text) || double.Parse(ikkunankorkeus.Text) > 300 && 30 < double.Parse(ikkunanleveys.Text) || double.Parse(ikkunanleveys.Text) > 300)
                {
                    double ala = double.Parse(ikkunanleveys.Text) * double.Parse(ikkunankorkeus.Text);
                    ikkunanpinta_ala.Text = ala.ToString() + "cm^2";
                    double lasiala = (double.Parse(ikkunanleveys.Text) - double.Parse(karminleveys.Text) * 2) * (double.Parse(ikkunankorkeus.Text) - double.Parse(karminleveys.Text) * 2);
                    lasinpinta_ala.Text = lasiala.ToString() + "cm^2";
                    double piiri = ((double.Parse(ikkunanleveys.Text) - double.Parse(karminleveys.Text) * 2) * 2) + ((double.Parse(ikkunankorkeus.Text) - double.Parse(karminleveys.Text) * 2) * 2);
                    karminpiiri.Text = piiri.ToString() + "cm";
                    neliö.Width = double.Parse(ikkunanleveys.Text) - double.Parse(karminleveys.Text);
                    neliö.Height = double.Parse(ikkunankorkeus.Text) - double.Parse(karminleveys.Text);
                    ruskeaneliö.Width = double.Parse(ikkunanleveys.Text);
                    ruskeaneliö.Height = double.Parse(ikkunankorkeus.Text);
                }
                else
                {
                    ikkunankorkeus.Text = "arvot oltava väliltä 30-300";
                    ikkunanleveys.Text = "arvot oltava väliltä 30-300";

                }
                
            }
        }
    }
}
