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
    public sealed partial class BlankPage1 : Page
    {
        public static Button ShowFoldersBtn { get; set; }
        public static ListView FoldersListView { get; set; }
        public static Button ShowMsgBoxBtn { get; set; }
        public BlankPage1()
        {
            this.InitializeComponent();

            //assign the controls to their respective variables so that it can be accessed in the wpf window and controlled from there
            ShowFoldersBtn = FoldersShowBtn;
            FoldersListView = ListFoldersView;
            ShowMsgBoxBtn = ShowMessageBoxButton;

        }

    }
}
