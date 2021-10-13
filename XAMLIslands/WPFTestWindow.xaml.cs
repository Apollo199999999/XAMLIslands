using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace XAMLIslands
{
    /// <summary>
    /// Interaction logic for WPFTestWindow.xaml
    /// </summary>
    public partial class WPFTestWindow : Window
    {
        public WPFTestWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //show a messagebox
            MessageBox.Show("You have just clicked a WPF button");
        }
    }
}
