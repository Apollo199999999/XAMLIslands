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
using System.IO;
using System.Windows.Threading;
using System.Diagnostics;

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

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            Debug.WriteLine("hello");
           
        }

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
            HostPage.frame.Navigated += Frame_Navigated;
            

        }

        private void Frame_Navigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            BlankPage1.ShowMsgBoxBtn.Click += ShowMsgBoxBtn_Click;
            BlankPage1.ShowFoldersBtn.Click += ShowFoldersBtn_Click;
        }

        private void WindowsXamlHost_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void ShowMsgBoxBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked in BlankPage1 " +
               "(MessageBoxes cannot be displayed in a UWP App, but they can be displayed in a WPF App)");
        }

        private void ShowFoldersBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //get folders in C:\ and add them to the UWP listview iteratively
            foreach (string dir in Directory.GetDirectories("C:\\"))
            {
                //add the dir to the listview
                BlankPage1.FoldersListView.Items.Add(dir);
            }


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
