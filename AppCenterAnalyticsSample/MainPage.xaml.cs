using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.AppCenter.Analytics;

namespace AppCenterAnalyticsSample
{
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();

            Analytics.TrackEvent("Page Opened",
                new Dictionary<string, string>() { { "Page", nameof(MainPage) } });
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Button Clicked",
                new Dictionary<string, string>() { { "Times Clicked", i++.ToString() } });
        }
    }
}
