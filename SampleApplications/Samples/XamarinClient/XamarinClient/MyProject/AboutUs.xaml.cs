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
	public partial class AboutUs : ContentPage
	{
        SampleClient opcClient;

		public AboutUs (SampleClient client)
		{
			InitializeComponent ();
            opcClient = client;
		}

        async void btBack_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage(opcClient);
        }
    }
}