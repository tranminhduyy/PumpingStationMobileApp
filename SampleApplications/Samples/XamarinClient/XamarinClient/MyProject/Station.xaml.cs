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
	public partial class Station : ContentPage
	{
        SampleClient opcClient;

        public Station (SampleClient client)
		{
			InitializeComponent ();
            opcClient = client;
		}
        async void OnBackClicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage(opcClient);
        }
        async void btPump_1_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Pump(opcClient, 1);
        }
        async void btPump_2_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Pump(opcClient, 2);
        }
        async void btPump_3_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Pump(opcClient, 3);
        }
        async void btPump_4_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Pump(opcClient, 4);
        }
        async void btRaker_1_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Raker(opcClient, 1);
        }
        async void btRaker_2_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Raker(opcClient, 2);
        }
        async void btRaker_3_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Raker(opcClient, 3);
        }
        async void btRaker_4_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Raker(opcClient, 4);
        }
        async void btConveyer_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_Conveyer(opcClient);
        }
        async void btGeneral_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Page_General(opcClient);
        }
    }
}