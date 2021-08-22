using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class MainPagePumpStation : Form
    {
        public bool Pump_1_RunFeedback;
        public bool Pump_2_RunFeedback;
        public bool Pump_3_RunFeedback;
        public bool Pump_4_RunFeedback;
        public bool Raker_1_RunFeedback;
        public bool Raker_2_RunFeedback;
        public bool Raker_3_RunFeedback;
        public bool Raker_4_RunFeedback;
        public bool Conveyer_RunFeedback;
        public float General_LevelInSuctionTank_Filtered;
        public float General_LevelOutDischargeTank_Filtered;

        public MainPagePumpStation()
        {
            InitializeComponent();
        }

        private void btPump_1_Click(object sender, EventArgs e)
        {
            Program.Pump_1.Show(1);
        }

        private void btPump_2_Click(object sender, EventArgs e)
        { 
            Program.Pump_2.Show(2);
        }

        private void btPump_3_Click(object sender, EventArgs e)
        {
            Program.Pump_3.Show(3);
        }

        private void btPump_4_Click(object sender, EventArgs e)
        {
            Program.Pump_4.Show(4);
        }

        private void btRaker_1_Click(object sender, EventArgs e)
        {
            Program.Raker_1.Show(1);
        }

        private void btRaker_2_Click(object sender, EventArgs e)
        {
            Program.Raker_2.Show(2);
        }

        private void btRaker_3_Click(object sender, EventArgs e)
        {
            Program.Raker_3.Show(3);
        }

        private void btRaker_4_Click(object sender, EventArgs e)
        {
            Program.Raker_4.Show(4);
        }

        private void btConveyer_Click(object sender, EventArgs e)
        {
            Program.Conveyer.Show();
        }

        private void btGeneral_Click(object sender, EventArgs e)
        {
            Program.General.Show();
        }

        private void MainPagePumpStation_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pump_1_RunFeedback = Data.Instance().Pump_1_RunFeedback;
            Pump_2_RunFeedback = Data.Instance().Pump_2_RunFeedback;
            Pump_3_RunFeedback = Data.Instance().Pump_3_RunFeedback;
            Pump_4_RunFeedback = Data.Instance().Pump_4_RunFeedback;

            Raker_1_RunFeedback = Data.Instance().Raker_1_RunFeedback;
            Raker_2_RunFeedback = Data.Instance().Raker_2_RunFeedback;
            Raker_3_RunFeedback = Data.Instance().Raker_3_RunFeedback;
            Raker_4_RunFeedback = Data.Instance().Raker_4_RunFeedback;

            Conveyer_RunFeedback = Data.Instance().Conveyer_RunFeedback;
            General_LevelInSuctionTank_Filtered = Data.Instance().LevelInSuctionTank_Filtered;

            Image light_green_off = Image.FromFile(@"Images\led_off.png");
            Image light_green_on = Image.FromFile(@"Images\led_green.png");

            if (Pump_1_RunFeedback)
            {
                pbPump_1.BackgroundImage = light_green_on;
                pbPump_1.BackColor = Color.Transparent;
                pbPump_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbPump_1.BackgroundImage = light_green_off;
                pbPump_1.BackColor = Color.Transparent;
                pbPump_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Pump_2_RunFeedback)
            {
                pbPump_2.BackgroundImage = light_green_on;
                pbPump_2.BackColor = Color.Transparent;
                pbPump_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbPump_2.BackgroundImage = light_green_off;
                pbPump_2.BackColor = Color.Transparent;
                pbPump_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Pump_3_RunFeedback)
            {
                pbPump_3.BackgroundImage = light_green_on;
                pbPump_3.BackColor = Color.Transparent;
                pbPump_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbPump_3.BackgroundImage = light_green_off;
                pbPump_3.BackColor = Color.Transparent;
                pbPump_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Pump_4_RunFeedback)
            {
                pbPump_4.BackgroundImage = light_green_on;
                pbPump_4.BackColor = Color.Transparent;
                pbPump_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbPump_4.BackgroundImage = light_green_off;
                pbPump_4.BackColor = Color.Transparent;
                pbPump_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Raker_1_RunFeedback)
            {
                pbRaker_1.BackgroundImage = light_green_on;
                pbRaker_1.BackColor = Color.Transparent;
                pbRaker_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_1.BackgroundImage = light_green_off;
                pbRaker_1.BackColor = Color.Transparent;
                pbRaker_1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Raker_2_RunFeedback)
            {
                pbRaker_2.BackgroundImage = light_green_on;
                pbRaker_2.BackColor = Color.Transparent;
                pbRaker_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_2.BackgroundImage = light_green_off;
                pbRaker_2.BackColor = Color.Transparent;
                pbRaker_2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Raker_3_RunFeedback)
            {
                pbRaker_3.BackgroundImage = light_green_on;
                pbRaker_3.BackColor = Color.Transparent;
                pbRaker_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_3.BackgroundImage = light_green_off;
                pbRaker_3.BackColor = Color.Transparent;
                pbRaker_3.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Raker_4_RunFeedback)
            {
                pbRaker_4.BackgroundImage = light_green_on;
                pbRaker_4.BackColor = Color.Transparent;
                pbRaker_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbRaker_4.BackgroundImage = light_green_off;
                pbRaker_4.BackColor = Color.Transparent;
                pbRaker_4.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (Conveyer_RunFeedback)
            {
                pbConveyer.BackgroundImage = light_green_on;
                pbConveyer.BackColor = Color.Transparent;
                pbConveyer.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbConveyer.BackgroundImage = light_green_off;
                pbConveyer.BackColor = Color.Transparent;
                pbConveyer.BackgroundImageLayout = ImageLayout.Stretch;
            }

            vpgSuctionTank.Value = Convert.ToInt32(General_LevelInSuctionTank_Filtered);
            tbLevelInSuctionTank_Filtered.Text = General_LevelInSuctionTank_Filtered.ToString();

            //var nodeid = "";
            //var value = "";

            //try
            //{
            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_1_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Pump_1_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_2_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Pump_2_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_3_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Pump_3_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_4_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Pump_4_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_1_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Raker_1_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_2_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Raker_2_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_3_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Raker_3_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_4_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Raker_4_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_RunFeedback";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    Conveyer_RunFeedback = Convert.ToBoolean(value);

            //    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
            //    value = PLC.Instance().VariableRead(nodeid);
            //    General_LevelInSuctionTank_Filtered = Convert.ToSingle(value);
            //}
            //catch
            //{

            //}
        }
    }
}
