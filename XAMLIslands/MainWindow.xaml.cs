using Microsoft.Toolkit.Wpf.UI.XamlHost;
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
using MyUWPApp;

namespace XAMLIslands
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

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
           


        }

        private void WindowsXamlHost_Loaded(object sender, RoutedEventArgs e)
        {
            BlankPage1.ButtonPress.Click += ButtonPress_Click;
        }

        private void ButtonPress_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked in BlankPage1 " +
                "(MessageBoxes cannot be displayed in a UWP App, but they can be displayed in a UWP App)");
        }
    }
}
