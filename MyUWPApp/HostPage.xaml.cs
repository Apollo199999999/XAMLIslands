using System;
using System.Collections.Generic;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MyUWPApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HostPage : Page
    {
        public HostPage()
        {
            this.InitializeComponent();
            NavView.SelectedItem = Page1;
            contentFrame.Navigate(typeof(BlankPage1));
        }

        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                contentFrame.Navigate(typeof(SettingsPage));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "Blank Page 1":
                        contentFrame.Navigate(typeof(BlankPage1));
                        break;
                    case "Blank Page 2":
                        contentFrame.Navigate(typeof(BlankPage2));
                        break;
                    case "Blank Page 3":
                        contentFrame.Navigate(typeof(BlankPage3));
                        break;

                }
            }
        }
    }
}
