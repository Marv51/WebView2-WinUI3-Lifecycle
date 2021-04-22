using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebView2_WinUI3_Lifecycle
{
    public static class Helpers
    {
        public static void GoBackIfPossible(Frame f)
        {
            if (f.CanGoBack)
            {
                f.GoBack();
            }
        }
    }
}
