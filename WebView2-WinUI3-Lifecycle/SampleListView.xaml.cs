using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;


namespace WebView2_WinUI3_Lifecycle
{
    public class WebSiteVM
    {
        public Uri TheUri { get; set; }
    }


    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SampleListView : Page
    {
        public ObservableCollection<WebSiteVM> AllTheWebsites { get; } = new ObservableCollection<WebSiteVM>();

        public SampleListView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            AllTheWebsites.Add(new WebSiteVM { TheUri = new Uri("https://github.com") });
            AllTheWebsites.Add(new WebSiteVM { TheUri = new Uri("https://microsoft.com") });
        }

        private void Button_Click(object sender, RoutedEventArgs e) => Helpers.GoBackIfPossible(Frame);

        private void MyWebView_WebMessageReceived(WebView2 sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs args)
        {

        }
    }
}
