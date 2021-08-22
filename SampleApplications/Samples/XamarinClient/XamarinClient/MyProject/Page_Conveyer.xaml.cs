using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClient
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_Conveyer : ContentPage
	{
        SampleClient opcClient;

        public short Mode;
        public bool Start;
        public bool Stop;
        public bool Reset;
        public bool RunFeedback;
        public short FaultID;

        bool start;
        bool stop;
        bool reset;

        public Page_Conveyer (SampleClient client)
		{
			InitializeComponent();
            opcClient = client;

            
            Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            {
                var img_off = ImageSource.FromFile("ledoff.png");
                var img_on_red = ImageSource.FromFile("ledred.png");
                var img_on_green = ImageSource.FromFile("ledgreen.png");

                if (Mode == 1) tbMode.Text = "Manual";
                else if (Mode == 2) tbMode.Text = "Auto";
                else if (Mode == 3) tbMode.Text = "Semi-Auto";
                else if (Mode == 4) tbMode.Text = "Service";
                
                if (RunFeedback) imgRunFeedback.Source = img_on_green;
                else imgRunFeedback.Source = img_off;

                tbFaultID.Text = FaultID.ToString();
                if (FaultID != 0)
                {
                    imgFault.Source = img_on_red;
                }
                else
                {
                    imgFault.Source = img_off;
                }


                var nodeid = "";
                var value = "";

                try
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_Mode";
                    value = opcClient.VariableRead(nodeid);
                    Mode = Convert.ToInt16(value);

                    if (start != Start)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_Start";
                        opcClient.VariableWrite(nodeid, Start);
                        start = Start;
                    }

                    if (stop != Stop)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_Stop";
                        opcClient.VariableWrite(nodeid, Stop);
                        stop = Stop;
                    }

                    if (reset != Reset)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_Reset";
                        opcClient.VariableWrite(nodeid, Reset);
                        reset = Reset;
                    }

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    FaultID = Convert.ToInt16(value);
                }
                catch
                {
                    DisplayAlert("Warning", "Something went wrong: PLC has stopped", "OK");
                }              

                return true;
            });
        }

        async void btStart_Pressed(object sender, EventArgs args)
        {
            Start = true;
        }
        async void btStart_Released(object sender, EventArgs args)
        {
            Start = false;
        }

        async void btStop_Pressed(object sender, EventArgs args)
        {
            Stop = true;
        }
        async void btStop_Released(object sender, EventArgs args)
        {
            Stop = false;
        }

        async void btReset_Pressed(object sender, EventArgs args)
        {
            Reset = true;
        }
        async void btReset_Released(object sender, EventArgs args)
        {
            Reset = false;
        }
        async void btBack_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Station(opcClient);
        }
    }
}