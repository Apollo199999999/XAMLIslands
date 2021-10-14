using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HostPage : Page
    {
        public static Frame frame { get; set; }

        public HostPage()
        {
            this.InitializeComponent();

            //assign the controls to their respective variables so that it can be accessed in the wpf window and controlled from there
            frame = contentFrame;

            //set the NavView SelectedItem manually
            NavView.SelectedItem = Page1;
        }

        private void NavView_SelectionChanged(MUXC.NavigationView sender, MUXC.NavigationViewSelectionChangedEventArgs args)
        {
            //this part controls which page to navigate to, upon user selection of a new NavViewItem
            if (NavView.SelectedItem == Page1)
            {
                contentFrame.Navigate(typeof(BlankPage1));
            }
            else if (NavView.SelectedItem == Page2)
            {
                contentFrame.Navigate(typeof(BlankPage2));
            }
            else if (NavView.SelectedItem == Page3)
            {
                contentFrame.Navigate(typeof(BlankPage3));
            }
            else if (NavView.SelectedItem == NavView.SettingsItem)
            {
                contentFrame.Navigate(typeof(SettingsPage));
            }
           
        }
    }
}
