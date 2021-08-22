using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace XamarinClient
{
	[XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Test : ContentPage
    {
        ObservableCollection<ListNode> nodes = new ObservableCollection<ListNode>();
        SampleClient opcClient;
        Tree storedTree;
        public Test(Tree tree, SampleClient client)
        {
            InitializeComponent();
            BindingContext = nodes;

            storedTree = tree;
            opcClient = client;
            var nodeid = "ns=3;s=\"counter\".CV";
            var value = "";
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                value = opcClient.VariableRead(nodeid);
                tbRead.Text = Convert.ToString(value);
                return true;
            });
            //var nodeid1 = "ns=3;s=\"AGITATOR\".\"START\"";
            //var value = opcClient.VariableRead(nodeid1);
            //DisplayAlert(nodeid1, value, "OK");

            //var nodeid2 = "ns=3;s=\"AGITATOR\".\"MODE\"";
            //Int16 number = 2;
            //opcClient.VariableWrite(nodeid2, number);
        }
        //private async Task Timer(int milisec,, Action actionToExcute)
        //{
        //    await Task.Delay(milisec);
        //    actionToExcute();
        //}
    }
}