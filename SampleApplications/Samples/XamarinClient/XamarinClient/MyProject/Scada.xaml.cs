using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Entry = Microcharts.Entry;
using Xamarin.Forms.Xaml;

namespace XamarinClient
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Scada : ContentPage
    {
        SampleClient opcClient;
        public float LevelInSuctionTank_Filtered;
        public bool Pump_1_RunFeedback;
        public short Pump_1_FaultID;
        public bool Pump_2_RunFeedback;
        public short Pump_2_FaultID;
        public bool Pump_3_RunFeedback;
        public short Pump_3_FaultID;
        public bool Pump_4_RunFeedback;
        public short Pump_4_FaultID;

        public bool Raker_1_RunFeedback;
        public short Raker_1_FaultID;
        public bool Raker_2_RunFeedback;
        public short Raker_2_FaultID;
        public bool Raker_3_RunFeedback;
        public short Raker_3_FaultID;
        public bool Raker_4_RunFeedback;
        public short Raker_4_FaultID;

        public bool Conveyer_RunFeedback;
        public short Conveyer_FaultID;

        List<Entry> entriesLevelInSuctionTank_Line;
        public Scada(SampleClient client)
        {
            InitializeComponent();
            opcClient = client;

            Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            {
                var nodeid = "";
                var value = "";
                try
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
                    value = opcClient.VariableRead(nodeid);
                    LevelInSuctionTank_Filtered = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_1_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Pump_1_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_1_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Pump_1_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_2_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Pump_2_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_2_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Pump_2_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_3_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Pump_3_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_3_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Pump_3_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_4_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Pump_4_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_4_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Pump_4_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_1_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Raker_1_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_1_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Raker_1_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_2_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Raker_2_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_2_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Raker_2_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_3_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Raker_3_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_3_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Raker_3_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_4_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Raker_4_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_4_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Raker_4_FaultID = Convert.ToInt16(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_RunFeedback";
                    value = opcClient.VariableRead(nodeid);
                    Conveyer_RunFeedback = Convert.ToBoolean(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_FaultID";
                    value = opcClient.VariableRead(nodeid);
                    Conveyer_FaultID = Convert.ToInt16(value);
                }
                catch
                {
                    DisplayAlert("Warning", "Something went wrong: PLC has stopped", "OK"); ;
                }
                
                #region LevelInSuctionTank
                tbLevelInSuctionTank.Text = LevelInSuctionTank_Filtered.ToString() + " m";

                entriesLevelInSuctionTank_Line = new List<Entry>
                {
                     new Entry(LevelInSuctionTank_Filtered)
                    {
                        Color =  SKColor.Parse("#59AFE2"),
                    },
                };

                LevelInSuctionTank_Chart.Chart = new BarChart()
                {
                    Entries = entriesLevelInSuctionTank_Line,
                    PointMode = PointMode.None,
                    PointSize = 18,
                    BackgroundColor = SKColor.Empty,
                    MinValue = 0,
                    MaxValue = 100,
                };

                #endregion

                #region Pump
                //1


                if (Pump_1_FaultID == 0)
                {
                    if (Pump_1_RunFeedback)
                    {
                        imgPump_1.Source = ImageSource.FromFile("pumpOn.png");
                        tbPump_1_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgPump_1.Source = ImageSource.FromFile("pump.png");
                        tbPump_1_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgPump_1.Source = ImageSource.FromFile("pumpFault.png");
                    tbPump_1_RunFeedback.Text = "OFF";
                }
                tbPump_1_FaultID.Text = Pump_1_FaultID.ToString();
                //2
                if (Pump_2_FaultID == 0)
                {
                    if (Pump_2_RunFeedback)
                    {
                        imgPump_2.Source = ImageSource.FromFile("pumpOn.png");
                        tbPump_2_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgPump_2.Source = ImageSource.FromFile("pump.png");
                        tbPump_2_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgPump_2.Source = ImageSource.FromFile("pumpFault.png");
                    tbPump_2_RunFeedback.Text = "OFF";
                }
                tbPump_2_FaultID.Text = Pump_2_FaultID.ToString();

                //3
                if (Pump_3_FaultID == 0)
                {
                    if (Pump_3_RunFeedback)
                    {
                        imgPump_3.Source = ImageSource.FromFile("pumpOn.png");
                        tbPump_3_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgPump_3.Source = ImageSource.FromFile("pump.png");
                        tbPump_3_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgPump_3.Source = ImageSource.FromFile("pumpFault.png");
                    tbPump_3_RunFeedback.Text = "OFF";
                }
                tbPump_3_FaultID.Text = Pump_3_FaultID.ToString();

                //4
                if (Pump_4_FaultID == 0)
                {
                    if (Pump_4_RunFeedback)
                    {
                        imgPump_4.Source = ImageSource.FromFile("pumpOn.png");
                        tbPump_4_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgPump_4.Source = ImageSource.FromFile("pump.png");
                        tbPump_4_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgPump_4.Source = ImageSource.FromFile("pumpFault.png");
                    tbPump_4_RunFeedback.Text = "OFF";
                }
                tbPump_4_FaultID.Text = Pump_4_FaultID.ToString();
                #endregion

                #region Raker
                //1
                if (Raker_1_FaultID == 0)
                {
                    if (Raker_1_RunFeedback)
                    {
                        imgRaker_1.Source = ImageSource.FromFile("rakerOn.png");
                        tbRaker_1_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgRaker_1.Source = ImageSource.FromFile("raker.png");
                        tbRaker_1_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgRaker_1.Source = ImageSource.FromFile("rakerFault.png");
                    tbRaker_1_RunFeedback.Text = "OFF";
                }
                tbRaker_1_FaultID.Text = Raker_1_FaultID.ToString();

                //2
                if (Raker_2_FaultID == 0)
                {
                    if (Raker_2_RunFeedback)
                    {
                        imgRaker_2.Source = ImageSource.FromFile("rakerOn.png");
                        tbRaker_2_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgRaker_2.Source = ImageSource.FromFile("raker.png");
                        tbRaker_2_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgRaker_2.Source = ImageSource.FromFile("rakerFault.png");
                    tbRaker_2_RunFeedback.Text = "OFF";
                }
                tbRaker_2_FaultID.Text = Raker_2_FaultID.ToString();

                //3
                if (Raker_3_FaultID == 0)
                {
                    if (Raker_3_RunFeedback)
                    {
                        imgRaker_3.Source = ImageSource.FromFile("rakerOn.png");
                        tbRaker_3_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgRaker_3.Source = ImageSource.FromFile("raker.png");
                        tbRaker_3_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgRaker_3.Source = ImageSource.FromFile("rakerFault.png");
                    tbRaker_3_RunFeedback.Text = "OFF";
                }
                tbRaker_3_FaultID.Text = Raker_3_FaultID.ToString();

                //4
                if (Raker_4_FaultID == 0)
                {
                    if (Raker_4_RunFeedback)
                    {
                        imgRaker_4.Source = ImageSource.FromFile("rakerOn.png");
                        tbRaker_4_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgRaker_4.Source = ImageSource.FromFile("raker.png");
                        tbRaker_4_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgRaker_4.Source = ImageSource.FromFile("rakerFault.png");
                    tbRaker_4_RunFeedback.Text = "OFF";
                }
                tbRaker_4_FaultID.Text = Raker_4_FaultID.ToString();
                #endregion

                #region Conveyer  


                if (Conveyer_FaultID == 0)
                {
                    if (Conveyer_RunFeedback)
                    {
                        imgConveyer.Source = ImageSource.FromFile("conveyerOn.png");
                        tbConveyer_RunFeedback.Text = "ON";
                    }
                    else
                    {
                        imgConveyer.Source = ImageSource.FromFile("conveyer.png");
                        tbConveyer_RunFeedback.Text = "OFF";
                    }
                }
                else
                {
                    imgConveyer.Source = ImageSource.FromFile("conveyerFault.png");
                    tbConveyer_RunFeedback.Text = "OFF";
                }
                tbConveyer_FaultID.Text = Conveyer_FaultID.ToString();
                #endregion
                return true;
            });
        }

        async void btBack_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage(opcClient);
        }
    }
}