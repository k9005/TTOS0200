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

namespace Lab11._1
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
            if ((bool)box1.IsChecked)
            {
                ostoslista.Text = "Maito\n";
            }
            if ((bool)box2.IsChecked)
            {
                ostoslista.Text = ostoslista.Text + "leipä\n";
            }
            if ((bool)box3.IsChecked)
            {
                ostoslista.Text = ostoslista.Text + "Kalja\n";
            }
            if ((bool)box4.IsChecked)
            {
                ostoslista.Text = ostoslista.Text + "Makkara\n";
            }
            if ((bool)box5.IsChecked)
            {
                ostoslista.Text = ostoslista.Text + "Raparperi\n";
            }
        }

       
    }

}
