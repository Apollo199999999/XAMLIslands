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

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
            HostPage.ContentFrame.Navigated += Frame_Navigated;

            //manually force the contentframe in the UWP NavView to navigate to all pages to force the event handler to trigger and initialize all the pages
            HostPage.ContentFrame.Navigate(typeof(BlankPage1));
            HostPage.ContentFrame.Navigate(typeof(BlankPage2));
            HostPage.ContentFrame.Navigate(typeof(BlankPage3));
            HostPage.ContentFrame.Navigate(typeof(SettingsPage));

            //navigate back to BlankPage1 
            HostPage.ContentFrame.Navigate(typeof(BlankPage1));
        }

        private void Frame_Navigated(object sender, Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            //place all UWP control event handlers here

            if(HostPage.ContentFrame.SourcePageType == typeof(BlankPage1))
            {
                //UWP BlankPage1 Event Handlers
                BlankPage1.ShowMsgBoxBtn.Click += ShowMsgBoxBtn_Click;
                BlankPage1.ShowFoldersBtn.Click += ShowFoldersBtn_Click;
                BlankPage1.ClearListViewBtn.Click += ClearListViewBtn_Click;
            }
            else if (HostPage.ContentFrame.SourcePageType == typeof(BlankPage2))
            {
                //UWP BlankPage2 Event Handlers
                BlankPage2.OpenWPFWindowBtn.Click += OpenWPFWindowBtn_Click;
            }
            else if (HostPage.ContentFrame.SourcePageType == typeof(BlankPage3))
            {
                //UWP BlankPage3 Event Handlers
                //...
            }
            else if (HostPage.ContentFrame.SourcePageType == typeof(SettingsPage))
            {
                //UWP SettingsPage Event Handlers
                //...
            }



        }

        private void OpenWPFWindowBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //show the WPFTestWindow
            WPFTestWindow wPFTestWindow = new WPFTestWindow();
            wPFTestWindow.Show();
        }

        private void ClearListViewBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            //clear all the items in the UWP listview
            BlankPage1.FoldersListView.Items.Clear();
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

                //create a new listview item
                Windows.UI.Xaml.Controls.ListViewItem listViewItem = new Windows.UI.Xaml.Controls.ListViewItem();
                listViewItem.Content = dir;
                listViewItem.Tag = dir;
                listViewItem.Tapped += ListViewItem_Tapped;

                //add listviewitem to uwp listview
                BlankPage1.FoldersListView.Items.Add(listViewItem);
      
            }


        }

        private void ListViewItem_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            //start the filepath in the tag of the listviewitem
            string process = (sender as Windows.UI.Xaml.Controls.ListViewItem).Tag.ToString();
            Process.Start("explorer.exe", process);
        }
    }
}
