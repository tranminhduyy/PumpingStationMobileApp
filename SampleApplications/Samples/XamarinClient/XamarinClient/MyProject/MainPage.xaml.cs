using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClient
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        SampleClient opcClient;

        public MainPage (SampleClient client)
		{
			InitializeComponent();
            opcClient = client;
        }
        async void OnStationClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Station(opcClient);
        }
        async void OnChartClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Chart(opcClient);
        }
        async void OnScadaClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Scada(opcClient);
        }
        async void OnAboutUsClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new AboutUs(opcClient);
        }
    }
}