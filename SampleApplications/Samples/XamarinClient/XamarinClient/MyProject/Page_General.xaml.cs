using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinClient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_General : ContentPage
    {
        ObservableCollection<ListNode> nodes = new ObservableCollection<ListNode>();
        SampleClient opcClient;

        public short GlobalMode;
        public float Temperature;
        public float Humidity;
        public bool EmptySuctionTank;
        public int PumpRunDelay;
        public float LevelInSuctionTank_Filtered;
        public float Above_Level;
        public float Bottom_Level;
        public int ConveyerStopDelay;      
        public int TimeLimit;
        public int MasterChangeFrequency;
        public int RakerRunDelay;
        public int RakerStopDelay;

        short globalmode;
        int pumprundelay;
        float above_level;
        float bottom_level;
        int conveyerstopdelay;
        int timelimit;
        int masterchangefrequency;
        int rakerrundelay;
        int rakerstopdelay;

        public string strGlobalMode;

        public Page_General(SampleClient client) 
        {
            InitializeComponent();
            opcClient = client;   

            Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            {
                var img_off = ImageSource.FromFile("ledoff.png");
                var img_on_red = ImageSource.FromFile("ledred.png");
                var img_on_green = ImageSource.FromFile("ledgreen.png");        

                tbTemperature.Text = Temperature.ToString();
                tbHumidity.Text = Humidity.ToString();            

                if (EmptySuctionTank) imgEmptySuctionTank.Source = img_on_red;
                else imgEmptySuctionTank.Source = img_off;

                object obj;
                bool ret;
                if (tbPumpRunDelay.Text != "")
                {
                    ret = Utilities.TryParse(tbPumpRunDelay.Text, "Int32", out obj);
                    if (ret)
                    {
                        PumpRunDelay = (int)obj;
                    }
                }

                tbLevelInSuctionTank.Text = LevelInSuctionTank_Filtered.ToString();

                if (tbAbove_Level.Text != "")
                {
                    ret = Utilities.TryParse(tbAbove_Level.Text, "Real", out obj);
                    if (ret)
                    {
                        Above_Level = (float)obj;
                    }
                }

                if (tbBottom_Level.Text != "")
                {
                    ret = Utilities.TryParse(tbBottom_Level.Text, "Real", out obj);
                    if (ret)
                    {
                        Bottom_Level = (float)obj;
                    }
                }
                if (tbConveyerStopDelay.Text != "")
                {
                    ret = Utilities.TryParse(tbConveyerStopDelay.Text, "Int32", out obj);
                    if (ret)
                    {
                        ConveyerStopDelay = (int)obj;
                    }
                }
                if (tbTimeLimit.Text != "")
                {
                    ret = Utilities.TryParse(tbTimeLimit.Text, "Int32", out obj);
                    if (ret)
                    {
                        TimeLimit = (int)obj;
                    }
                }
                if (tbMasterChangeFrequency.Text != "")
                {
                    ret = Utilities.TryParse(tbMasterChangeFrequency.Text, "Int32", out obj);
                    if (ret)
                    {
                        MasterChangeFrequency = (int)obj;
                    }
                }
                if (tbRakerRunDelay.Text != "")
                {
                    ret = Utilities.TryParse(tbRakerRunDelay.Text, "Int32", out obj);
                    if (ret)
                    {
                        RakerRunDelay = (int)obj;
                    }
                }
                if (tbRakerStopDelay.Text != "")
                {
                    ret = Utilities.TryParse(tbRakerStopDelay.Text, "Int32", out obj);
                    if (ret)
                    {
                        RakerStopDelay = (int)obj;
                    }
                }

                var nodeid = "";
                var value = "";

                try
                {
                    if (globalmode != GlobalMode)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_GlobalMode";
                        opcClient.VariableWrite(nodeid, GlobalMode);
                        globalmode = GlobalMode;
                    }

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Temperature";
                    value = opcClient.VariableRead(nodeid);
                    Temperature = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Humidity";
                    value = opcClient.VariableRead(nodeid);
                    Humidity = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
                    value = opcClient.VariableRead(nodeid);
                    LevelInSuctionTank_Filtered = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_EmptySuctionTank";
                    value = opcClient.VariableRead(nodeid);
                    EmptySuctionTank = Convert.ToBoolean(value);

                    if (pumprundelay != PumpRunDelay)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_PumpRunDelay";
                        opcClient.VariableWrite(nodeid, PumpRunDelay);
                        pumprundelay = PumpRunDelay;
                    }
                    if (above_level != Above_Level)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Above_Level";
                        opcClient.VariableWrite(nodeid, Above_Level);
                        above_level = Above_Level;
                    }
                    if (bottom_level != Bottom_Level)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Bottom_Level";
                        opcClient.VariableWrite(nodeid, Bottom_Level);
                        bottom_level = Bottom_Level;
                    }
                    if (conveyerstopdelay != ConveyerStopDelay)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_ConveyerStopDelay";
                        opcClient.VariableWrite(nodeid, ConveyerStopDelay);
                        conveyerstopdelay = ConveyerStopDelay;
                    }
                    if (timelimit != TimeLimit)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_TimeLimit";
                        opcClient.VariableWrite(nodeid, TimeLimit);
                        timelimit = TimeLimit;
                    }
                    if (masterchangefrequency != MasterChangeFrequency)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_MasterChangeFrequency";
                        opcClient.VariableWrite(nodeid, MasterChangeFrequency);
                        masterchangefrequency = MasterChangeFrequency;
                    }
                    if (rakerrundelay != RakerRunDelay)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerRunDelay";
                        opcClient.VariableWrite(nodeid, RakerRunDelay);
                        rakerrundelay = RakerRunDelay;
                    }
                    if (rakerstopdelay != RakerStopDelay)
                    {
                        nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerStopDelay";
                        opcClient.VariableWrite(nodeid, RakerStopDelay);
                        rakerstopdelay = RakerStopDelay;
                    }
                }
                catch 
                {
                    DisplayAlert("Warning", "Something went wrong: PLC has stopped", "OK");
                }

                return true;
            });

            piGlobalMode.SelectedIndexChanged += (sender, args) =>
            {
                if (piGlobalMode.SelectedIndex == -1)
                {
                    strGlobalMode = "Nil Value";
                }
                else
                {
                    strGlobalMode = piGlobalMode.Items[piGlobalMode.SelectedIndex];
                    if (strGlobalMode == "Manual") GlobalMode = 1;
                    else if (strGlobalMode == "Auto") GlobalMode = 2;
                    else if (strGlobalMode == "Semi-Auto") GlobalMode = 3;
                    else if (strGlobalMode == "Service") GlobalMode = 4;
                }
            };
        }
            
        async void btBack_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new Station(opcClient);
        }
    }
}