using MUXC = Microsoft.UI.Xaml.Controls;
using System.Globalization;
using Microsoft.Toolkit.Win32.UI.XamlHost;

namespace MyUWPApp
{
    public sealed partial class App : Microsoft.Toolkit.Win32.UI.XamlHost.XamlApplication
    {
        public App()
        {
            this.Initialize();
        }
    }
}