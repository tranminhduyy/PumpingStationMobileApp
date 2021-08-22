using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Page_Pump : Form
    {
        public bool Start;
        public bool Stop;
        public bool RunFeedback;
        public short FaultID;
        public short Mode;        
        public bool Reset;

        public short Number;

        public Page_Pump()
        {
            InitializeComponent();
        }

        public void Show(short number)
        {
            Number = number;
            Show();
            BringToFront();
        }
        
        private void Page_Pump_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void StopTimer1()
        {
            if (timer1 != null)
            {
                timer1.Dispose();
                timer1 = null;
            }
        }

        bool start;
        bool stop;
        bool reset;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mode = Data.Instance().GlobalMode;

            if (Number.Equals(1))
            {
                RunFeedback = Data.Instance().Pump_1_RunFeedback;
                FaultID = Data.Instance().Pump_1_FaultID;
            }
            else if (Number.Equals(2))
            {
                RunFeedback = Data.Instance().Pump_2_RunFeedback;
                FaultID = Data.Instance().Pump_2_FaultID;
            }
            else if (Number.Equals(3))
            {
                RunFeedback = Data.Instance().Pump_3_RunFeedback;
                FaultID = Data.Instance().Pump_3_FaultID;
            }
            else if (Number.Equals(4))
            {
                RunFeedback = Data.Instance().Pump_4_RunFeedback;
                FaultID = Data.Instance().Pump_4_FaultID;
            }

            if (Properties.Settings.Default.User.Equals("Engineer") || Properties.Settings.Default.User.Equals("Admin"))
            {
                btStart.Enabled = true;
                btStop.Enabled = true;
                btReset.Enabled = true;
            }
            else
            {
                btStart.Enabled = false;
                btStop.Enabled = false;
                btReset.Enabled = false;
            }

            Image button_green_released = Image.FromFile(@"Images\bt_green_release.png");
            Image button_green_pressed = Image.FromFile(@"Images\bt_green_press.png");
            Image button_red_released = Image.FromFile(@"Images\bt_red_release.png");
            Image button_red_pressed = Image.FromFile(@"Images\bt_red_press.png");
            Image light_green_off = Image.FromFile(@"Images\led_off.png");
            Image light_green_on = Image.FromFile(@"Images\led_green.png");
            Image light_red_off = Image.FromFile(@"Images\led_off.png");
            Image light_red_on = Image.FromFile(@"Images\led_red.png");

            tbNumber.Text = Number.ToString();

            if (Mode == 1)
                tbMode.Text = "Manual";
            else if (Mode == 2)
                tbMode.Text = "Auto";
            else if (Mode == 3)
                tbMode.Text = "Semi-Auto";
            else if (Mode == 4)
                tbMode.Text = "Service";

            if (RunFeedback)
            {
                pbRunFeedback.BackgroundImage = light_green_on;
                pbRunFeedback.BackColor = Color.Transparent;
                pbRunFeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRunFeedback.BackgroundImage = light_green_off;
                pbRunFeedback.BackColor = Color.Transparent;
                pbRunFeedback.BackgroundImageLayout = ImageLayout.Stretch;
            }

            tbFaultID.Text = FaultID.ToString();

            if (FaultID != 0)
            {
                pbFault.BackgroundImage = light_red_on;
                pbFault.BackColor = Color.Transparent;
                pbFault.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbFault.BackgroundImage = light_red_off;
                pbFault.BackColor = Color.Transparent;
                pbFault.BackgroundImageLayout = ImageLayout.Stretch;
            }

            var nodeid = "";
            var value = "";

            try
            {
                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_Mode";
                //value = PLC.Instance().VariableRead(nodeid);
                //Mode = Convert.ToInt16(value);

                if (Start != start)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_Start";
                    PLC.Instance().VariableWrite(nodeid, Start);
                    start = Start;
                }

                if (Stop != stop)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_Stop";
                    PLC.Instance().VariableWrite(nodeid, Stop);
                    stop = Stop;
                }

                if (Reset != reset)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_Reset";
                    PLC.Instance().VariableWrite(nodeid, Reset);
                    reset = Reset;
                }

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_RunFeedback";
                //value = PLC.Instance().VariableRead(nodeid);
                //RunFeedback = Convert.ToBoolean(value);

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_" + Number.ToString() + "_FaultID";
                //value = PLC.Instance().VariableRead(nodeid);
                //FaultID = Convert.ToInt16(value);

            }
            catch
            {

            }
        }       

        private void btStart_CheckedChanged(object sender, EventArgs e)
        {
            if (btStart.Checked == true)
            {
                Start = true;
                btStart.BackgroundImage = Image.FromFile(@"Images\bt_green_press.png");
                btStart.BackColor = Color.Transparent;
                btStart.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                Start = false;
                btStart.BackgroundImage = Image.FromFile(@"Images\bt_green_release.png");
                btStart.BackColor = Color.Transparent;
                btStart.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btStop_CheckedChanged(object sender, EventArgs e)
        {
            if (btStop.Checked == true)
            {
                Stop = true;
                btStop.BackgroundImage = Image.FromFile(@"Images\bt_red_press.png");
                btStop.BackColor = Color.Transparent;
                btStop.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                Stop = false;
                btStop.BackgroundImage = Image.FromFile(@"Images\bt_red_release.png");
                btStop.BackColor = Color.Transparent;
                btStop.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btReset_CheckedChanged(object sender, EventArgs e)
        {
            if (btReset.Checked == true)
            {
                Reset = true;
                btReset.BackgroundImage = Image.FromFile(@"Images\bt_red_press.png");
                btReset.BackColor = Color.Transparent;
                btReset.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                Reset = false;
                btReset.BackgroundImage = Image.FromFile(@"Images\bt_red_release.png");
                btReset.BackColor = Color.Transparent;
                btReset.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btCheckFaultID_Click(object sender, EventArgs e)
        {
            var ms1 = "";
            var ms2 = "";
            var ms3 = "";
            var ms4 = "";
            var ms5 = "";
            var ms6 = "";
            var ms7 = "";
            var ms8 = "";
            var ms9 = "";

            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(1))   == 1)   ms1 = "Lỗi khởi động mềm\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(2))   == 2)   ms2 = "Lỗi quá nhiệt cuộn dây\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(4))   == 4)   ms3 = "Lỗi quá nhiệt bạc đạn trên\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(8))   == 8)   ms4 = "Lỗi quá nhiệt bạc đạn dưới\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(16))  == 16)  ms5 = "Lỗi độ ẩm xâm nhập vào buồng kết nối điện động cơ\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(32))  == 32)  ms6 = "Lỗi độ ẩm xâm nhập vào buồng cuộn dây động cơ\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(64))  == 64)  ms7 = "Lỗi độ ẩm xâm nhập vào buồng dầu động cơ\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(128)) == 128) ms8 = "Lỗi bơm không hoạt động\n";
            if ((Convert.ToInt16(FaultID) & Convert.ToInt16(256)) == 256) ms9 = "Lỗi van đầu xả không hoạt động";

            var ms = ms1 + ms2 + ms3 + ms4 + ms5 + ms6 + ms7 + ms8 + ms9;
            MessageBox.Show(ms);
        }

        private void Page_Pump_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Page_Pump_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopTimer1();
        }
    }
}
