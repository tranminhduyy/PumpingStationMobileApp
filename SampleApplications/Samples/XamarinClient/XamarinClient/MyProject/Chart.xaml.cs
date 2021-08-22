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
	public partial class Chart : ContentPage
	{
        SampleClient opcClient;

        List<Entry> entriesTem_Gauge;
        List<Entry> entriesTem_Line;
        List<Entry> entriesHumidity_Gauge;
        List<Entry> entriesHumidity_Line;
        List<Entry> entriesLevelInSuctionTank_Line;
        public float Temperature;
        public float Humidity;
        public float LevelInSuctionTank_Filtered;
        public float _t1, _t2, _t3, _t4;
        public float _h1, _h2, _h3, _h4;
        public float preLevel;

        public Chart (SampleClient client)
        {
			InitializeComponent ();
            opcClient = client;

            entriesLevelInSuctionTank_Line = new List<Entry>();
            DateTime current, _c1, _c2, _c3, _c4;
            string color, color1, color2, color3, color4;

            Device.StartTimer(TimeSpan.FromMilliseconds(2000), () =>
            {
                var nodeid = "";
                var value = "";
                try
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Temperature";
                    value = opcClient.VariableRead(nodeid);
                    Temperature = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Humidity";
                    value = opcClient.VariableRead(nodeid);
                    Humidity = Convert.ToSingle(value);

                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
                    value = opcClient.VariableRead(nodeid);
                    LevelInSuctionTank_Filtered = Convert.ToSingle(value);
                }
                catch
                {
                    DisplayAlert("Warning", "Something went wrong: PLC has stopped", "OK");
                }

                #region Temperature
                tbTemperature.Text = Temperature.ToString();

                if (Temperature - _t1 >= 0)
                {
                    imgTem_UpOrDown.Source = ImageSource.FromFile("uparrow.png");
                    tbTem_Gap.Text = (Temperature - _t1).ToString();
                    tbTem_Gap.TextColor = Color.FromHex("#7CBB34");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((Temperature - _t1) / _t1) * 100);
                    tbTem_GapPercentage.Text = "(" + s_GapPercentage + "%)";
                    tbTem_GapPercentage.TextColor = Color.FromHex("#7CBB34");
                }
                else
                {
                    imgTem_UpOrDown.Source = ImageSource.FromFile("downarrow.png");
                    tbTem_Gap.Text = (_t1 - Temperature).ToString();
                    tbTem_Gap.TextColor = Color.FromHex("#FF2222");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((_t1 - Temperature) / _t1) * 100);
                    tbTem_GapPercentage.Text = "(" + s_GapPercentage + "%)";
                    tbTem_GapPercentage.TextColor = Color.FromHex("#FF2222");
                }


                current = DateTime.Now; //DateTime.Now.ToString("h:mm:ss tt");
                tbTem_DateTime.Text = current.ToString("dd MMM yyy HH:mm ‘GMT’");

                _c1 = DateTime.Now.AddMilliseconds(-2000);
                _c2 = DateTime.Now.AddMilliseconds(-4000);
                _c3 = DateTime.Now.AddMilliseconds(-6000);
                _c4 = DateTime.Now.AddMilliseconds(-8000);

                entriesTem_Gauge = new List<Entry>
                {
                    new Entry(Temperature)
                    {
                        Color=SKColor.Parse("#FACC27"),
                        Label = "Temperature",
                        ValueLabel = Temperature.ToString()
                    }
                };

                Tem_GaugeChart.Chart = new RadialGaugeChart()
                {
                    Entries = entriesTem_Gauge,
                    MinValue = 0,
                    MaxValue = 100,
                    BackgroundColor = SKColor.Empty,
                    LabelTextSize = 30f,
                };


                if (Temperature < 25) color = "#DC9063";
                else if (Temperature >= 25 && Temperature < 50) color = "#FFD302";
                else if (Temperature >= 75 && Temperature < 75) color = "#E77B0B";
                else color = "#FA4E3A";

                if (_t1 < 25) color1 = "#DC9063";
                else if (_t1 >= 25 && _t1 < 50) color1 = "#FFD302";
                else if (_t1 >= 75 && _t1 < 75) color1 = "#E77B0B";
                else color1 = "#FA4E3A";

                if (_t2 < 25) color2 = "#DC9063";
                else if (_t2 >= 25 && _t2 < 50) color2 = "#FFD302";
                else if (_t2 >= 75 && _t2 < 75) color2 = "#E77B0B";
                else color2 = "#FA4E3A";

                if (_t3 < 25) color3 = "#DC9063";
                else if (_t3 >= 25 && _t3 < 50) color3 = "#FFD302";
                else if (_t3 >= 75 && _t3 < 75) color3 = "#E77B0B";
                else color3 = "#FA4E3A";

                if (_t4 < 25) color4 = "#DC9063";
                else if (_t4 >= 25 && _t4 < 50) color4 = "#FFD302";
                else if (_t4 >= 75 && _t4 < 75) color4 = "#E77B0B";
                else color4 = "#FA4E3A";

                entriesTem_Line = new List<Entry>
                {
                     new Entry(_t4)
                    {
                        Color =  SKColor.Parse(color4),
                        Label = _c4.ToString("h:mm:ss tt"),
                        ValueLabel = _t4.ToString()
                    },
                     new Entry(_t3)
                    {
                        Color =  SKColor.Parse(color3),
                        Label = _c3.ToString("h:mm:ss tt"),
                        ValueLabel = _t3.ToString()
                    },
                     new Entry(_t2)
                    {
                        Color =  SKColor.Parse(color2),
                        Label = _c2.ToString("h:mm:ss tt"),
                        ValueLabel = _t2.ToString()
                    },
                     new Entry(_t1)
                    {
                        Color =  SKColor.Parse(color1),
                        Label = _c1.ToString("h:mm:ss tt"),
                        ValueLabel = _t1.ToString()
                    },
                     new Entry(Temperature)
                    {
                        Color =  SKColor.Parse(color),
                        Label = current.ToString("h:mm:ss tt"),
                        ValueLabel = Temperature.ToString()
                    },
                };

                Tem_Chart.Chart = new LineChart()
                {
                    Entries = entriesTem_Line,
                    LineMode = LineMode.Straight,
                    LineSize = 8,
                    PointMode = PointMode.Square,
                    PointSize = 18,
                    BackgroundColor = SKColor.Empty,
                    MinValue = 0,
                    MaxValue = 100,
                    LabelTextSize = 25,
                };

                _t4 = _t3;
                _t3 = _t2;
                _t2 = _t1;
                _t1 = Temperature;
                #endregion

                #region Humidity
                
                tbHumidity.Text = Humidity.ToString();
                if (Humidity - _h1 >= 0)
                {
                    imgHumidity_UpOrDown.Source = ImageSource.FromFile("uparrow.png");
                    tbHumidity_Gap.Text = (Humidity - _h1).ToString();
                    tbHumidity_Gap.TextColor = Color.FromHex("#7CBB34");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((Humidity - _h1) / _h1) * 100);
                    tbHumidity_GapPercentage.Text = "(" + s_GapPercentage + "%)";
                    tbHumidity_GapPercentage.TextColor = Color.FromHex("#7CBB34");
                }
                else
                {
                    imgHumidity_UpOrDown.Source = ImageSource.FromFile("downarrow.png");
                    tbHumidity_Gap.Text = (_h1 - Humidity).ToString();
                    tbHumidity_Gap.TextColor = Color.FromHex("#FF2222");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((_h1 - Humidity) / _h1) * 100);
                    tbTem_GapPercentage.Text = "(" + s_GapPercentage + "%)";
                    tbTem_GapPercentage.TextColor = Color.FromHex("#FF2222");
                }

                tbHumidity_DateTime.Text = current.ToString("dd MMM yyy HH:mm ‘GMT’");

                entriesHumidity_Gauge = new List<Entry>
                {
                    new Entry(Humidity)
                    {
                        Color=SKColor.Parse("#FACC27"),
                        Label = "Humidity",
                        ValueLabel = Humidity.ToString()
                    }
                };

                Humidity_GaugeChart.Chart = new RadialGaugeChart()
                {
                    Entries = entriesHumidity_Gauge,
                    MinValue = 0,
                    MaxValue = 100,
                    BackgroundColor = SKColor.Empty,
                    LabelTextSize = 30f,
                };

                if (Humidity < 25) color = "#AFB0DF";
                else if (Humidity >= 25 && Humidity < 50) color = "#9797D7";
                else if (Humidity >= 75 && Humidity < 75) color = "#807CD3";
                else color = "#6965C7";

                if (_h1 < 25) color1 = "#AFB0DF";
                else if (_h1 >= 25 && _h1 < 50) color1 = "#9797D7";
                else if (_h1 >= 75 && _h1 < 75) color1 = "#807CD3";
                else color1 = "#6965C7";

                if (_h2 < 25) color2 = "#AFB0DF";
                else if (_h2 >= 25 && _h2 < 50) color2 = "#9797D7";
                else if (_h2 >= 75 && _h2 < 75) color2 = "#807CD3";
                else color2 = "#6965C7";

                if (_h3 < 25) color3 = "#AFB0DF";
                else if (_h3 >= 25 && _h3 < 50) color3 = "#9797D7";
                else if (_h3 >= 75 && _h3 < 75) color3 = "#807CD3";
                else color3 = "#6965C7";

                if (_h4 < 25) color4 = "#AFB0DF";
                else if (_h4 >= 25 && _h4 < 50) color4 = "#9797D7";
                else if (_h4 >= 75 && _h4 < 75) color4 = "#807CD3";
                else color4 = "#6965C7";

                entriesHumidity_Line = new List<Entry>
                {
                     new Entry(_h4)
                    {
                        Color =  SKColor.Parse(color4),
                        Label = _c4.ToString("h:mm:ss tt"),
                        ValueLabel = _h4.ToString()
                    },
                     new Entry(_h3)
                    {
                        Color =  SKColor.Parse(color3),
                        Label = _c3.ToString("h:mm:ss tt"),
                        ValueLabel = _h3.ToString()
                    },
                     new Entry(_h2)
                    {
                        Color =  SKColor.Parse(color2),
                        Label = _c2.ToString("h:mm:ss tt"),
                        ValueLabel = _h2.ToString()
                    },
                     new Entry(_h1)
                    {
                        Color =  SKColor.Parse(color1),
                        Label = _c1.ToString("h:mm:ss tt"),
                        ValueLabel = _h1.ToString()
                    },
                     new Entry(Humidity)
                    {
                        Color =  SKColor.Parse(color),
                        Label = current.ToString("h:mm:ss tt"),
                        ValueLabel = Humidity.ToString()
                    },
                };

                Humidity_Chart.Chart = new LineChart()
                {
                    Entries = entriesHumidity_Line,
                    LineMode = LineMode.Straight,
                    LineSize = 8,
                    PointMode = PointMode.Square,
                    PointSize = 18,
                    BackgroundColor = SKColor.Empty,
                    MinValue = 0,
                    MaxValue = 100,
                    LabelTextSize = 25,
                };

                _h4 = _h3;
                _h3 = _h2;
                _h2 = _h1;
                _h1 = Humidity;
                #endregion

                #region LevelInSuctionTank               
                tbLevelInSuctionTank.Text = LevelInSuctionTank_Filtered.ToString();

                if (LevelInSuctionTank_Filtered - preLevel >= 0)
                {
                    imgLevelInSuctionTank_UpOrDown.Source = ImageSource.FromFile("uparrow.png");
                    tbLevelInSuctionTank_Gap.Text = (LevelInSuctionTank_Filtered - preLevel).ToString();
                    tbLevelInSuctionTank_Gap.TextColor = Color.FromHex("#7CBB34");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((LevelInSuctionTank_Filtered - preLevel) / preLevel) * 100);
                    tbGapLevelInSuctionTank.Text = "(" + s_GapPercentage + "%)";
                    tbGapLevelInSuctionTank.TextColor = Color.FromHex("#7CBB34");
                }
                else
                {
                    imgLevelInSuctionTank_UpOrDown.Source = ImageSource.FromFile("downarrow.png");
                    tbLevelInSuctionTank_Gap.Text = (preLevel - LevelInSuctionTank_Filtered).ToString();
                    tbLevelInSuctionTank_Gap.TextColor = Color.FromHex("#FF2222");
                    string s_GapPercentage = System.String.Format("{0:0.##}", ((preLevel - LevelInSuctionTank_Filtered) / preLevel) * 100);
                    tbGapLevelInSuctionTank.Text = "(" + s_GapPercentage + "%)";
                    tbGapLevelInSuctionTank.TextColor = Color.FromHex("#FF2222");
                }

                tbLevelInSuctionTank_DateTime.Text = current.ToString("dd MMM yyy HH:mm ‘GMT’");

                if (LevelInSuctionTank_Filtered < 25) color = "#C0E4F6";
                else if (LevelInSuctionTank_Filtered >= 25 && LevelInSuctionTank_Filtered < 50) color = "#55CBF2";
                else if (LevelInSuctionTank_Filtered >= 75 && LevelInSuctionTank_Filtered < 75) color = "#178BC3";
                else color = "#23679F";

                string s_Current = DateTime.Now.ToString("h: mm:ss tt");

                entriesLevelInSuctionTank_Line.Add(new Entry(LevelInSuctionTank_Filtered)
                {
                    Color = SKColor.Parse(color),
                    Label = s_Current,
                    ValueLabel = LevelInSuctionTank_Filtered.ToString(),
                });

                LevelInSuctionTankChart.WidthRequest += 50;
                LevelInSuctionTankChart.Chart = new LineChart()
                {
                    Entries = entriesLevelInSuctionTank_Line,
                    LineMode = LineMode.Straight,
                    LineSize = 8,
                    PointMode = PointMode.Circle,
                    PointSize = 18,
                    BackgroundColor = SKColor.Empty,
                    MinValue = 0,
                    MaxValue = 100,
                    LabelTextSize = 15,
                };
                preLevel = LevelInSuctionTank_Filtered;
                #endregion
                _c1 = current;
                
                return true;
            });
        }

        async void btBack_Clicked(object sender, EventArgs args)
        {
            Application.Current.MainPage = new MainPage(opcClient);
        }
    }
}