﻿using System;
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

namespace WpfDemo
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
            string nimi = txtNimi.Text;
            txbMessu.Text = "HAck3rM4n " + nimi;
        }

        private void btnSuurenna_Click(object sender, RoutedEventArgs e)
        {
            txbMessu.FontSize = txbMessu.FontSize + 1;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem li = (ListBoxItem)cmbVarit.SelectedItem;
            string testi = li.Content.ToString();
            
            
            Brush mybrush = Brushes.Blue;
            txbMessu.Foreground = mybrush;
        }
    }
}
