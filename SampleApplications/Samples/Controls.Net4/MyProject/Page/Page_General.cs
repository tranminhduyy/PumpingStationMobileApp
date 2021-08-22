using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Page_General : Form
    {
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
        public int RackerRunDelay;
        public int RackerStopDelay;

        public string strGlobalMode;

        public Page_General()
        {
            InitializeComponent();
        }

        private void Page_General_Load(object sender, EventArgs e)
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

        short preMode;
        float bottom_level;
        float above_level;
        int timelimit;
        int masterchangefrequency;
        int rackerrundelay;
        int pumprundelay;
        int conveyerstopdelay;
        int rakerstopdelay;
        private void cbGlobalMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGlobalMode.Text == "Manual")
            {
                GlobalMode = 1;
                preMode = 0;
            }
            else if (cbGlobalMode.Text == "Auto")
            {
                GlobalMode = 2;
                preMode = 1;
            }
            else if (cbGlobalMode.Text == "Semi-Auto")
            {
                GlobalMode = 3;
                preMode = 2;
            }
            else if (cbGlobalMode.Text == "Service")
                if (Properties.Settings.Default.User == "Admin")
                {
                    GlobalMode = 4;
                    preMode = 3;
                }
                else
                {
                    cbGlobalMode.SelectedIndex = preMode;
                    MessageBox.Show("Please login with user Admin");
                }
        }

        short globalmode;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Temperature = Data.Instance().Temperature;
            Humidity = Data.Instance().Humidity;
            LevelInSuctionTank_Filtered = Data.Instance().LevelInSuctionTank_Filtered;
            EmptySuctionTank = Data.Instance().EmptySuctionTank;

            if (Properties.Settings.Default.User.Equals("Engineer") || Properties.Settings.Default.User.Equals("Admin"))
            {
                cbGlobalMode.Enabled = true;                
            }
            else
            {
                cbGlobalMode.Enabled = false;
            }
            if (Properties.Settings.Default.User.Equals("Admin"))
            {
                tbPumpRunDelay.Enabled = true;
                tbAbove_Level.Enabled = true;
                tbBottom_Level.Enabled = true;
                tbConveyerStopDelay.Enabled = true;
                tbTimeLimit.Enabled = true;
                tbMasterChangeFrequency.Enabled = true;
                tbRakerRunDelay.Enabled = true;
                tbRakerStopDelay.Enabled = true;
            }
            else
            {
                tbPumpRunDelay.Enabled = false;
                tbAbove_Level.Enabled = false;
                tbBottom_Level.Enabled = false;
                tbConveyerStopDelay.Enabled = false;
                tbTimeLimit.Enabled = false;
                tbMasterChangeFrequency.Enabled = false;
                tbRakerRunDelay.Enabled = false;
                tbRakerStopDelay.Enabled = false;
            }

            Image light_red_off = Image.FromFile(@"Images\led_off.png");
            Image light_red_on = Image.FromFile(@"Images\led_red.png");

            tbTemperature.Text = Temperature.ToString();
            tbHumidity.Text = Humidity.ToString();

            tbLevelInSuctionTank_Filtered.Text = LevelInSuctionTank_Filtered.ToString(); 

            if (EmptySuctionTank)
            {
                pbEmptySuctionTank.BackgroundImage = light_red_on;
                pbEmptySuctionTank.BackColor = Color.Transparent;
                pbEmptySuctionTank.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pbEmptySuctionTank.BackgroundImage = light_red_off;
                pbEmptySuctionTank.BackColor = Color.Transparent;
                pbEmptySuctionTank.BackgroundImageLayout = ImageLayout.Stretch;
            }

            var nodeid = "";
            var value = "";

            try
            {
                if (GlobalMode != globalmode)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_GlobalMode";
                    PLC.Instance().VariableWrite(nodeid, GlobalMode);
                    globalmode = GlobalMode;
                }
                if (PumpRunDelay != pumprundelay)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_PumpRunDelay";
                    PLC.Instance().VariableWrite(nodeid, PumpRunDelay);
                    pumprundelay = PumpRunDelay;
                }
                if (Above_Level != above_level)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Above_Level";
                    PLC.Instance().VariableWrite(nodeid, Above_Level);
                    above_level = Above_Level;
                }

                if (Bottom_Level != bottom_level)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Bottom_Level";
                    PLC.Instance().VariableWrite(nodeid, Bottom_Level);
                    bottom_level = Bottom_Level;
                }

                if (ConveyerStopDelay != conveyerstopdelay)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_ConveyerStopDelay";
                    PLC.Instance().VariableWrite(nodeid, ConveyerStopDelay);
                    conveyerstopdelay = ConveyerStopDelay;
                }
                if (TimeLimit != timelimit)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_TimeLimit";
                    PLC.Instance().VariableWrite(nodeid, TimeLimit);
                    timelimit = TimeLimit;
                }

                if (MasterChangeFrequency != masterchangefrequency)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_MasterChangeFrequency";
                    PLC.Instance().VariableWrite(nodeid, MasterChangeFrequency);
                    masterchangefrequency = MasterChangeFrequency;
                }

                if (RackerRunDelay != rackerrundelay)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerRunDelay";
                    PLC.Instance().VariableWrite(nodeid, RackerRunDelay);
                    rackerrundelay = RackerRunDelay;
                }

                if (RackerStopDelay != rakerstopdelay)
                {
                    nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerStopDelay";
                    PLC.Instance().VariableWrite(nodeid, RackerStopDelay);
                    rakerstopdelay = RackerStopDelay;
                }

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Temperature";
                //value = PLC.Instance().VariableRead(nodeid);
                //Temperature = Convert.ToSingle(value);

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Humidity";
                //value = PLC.Instance().VariableRead(nodeid);
                //Humidity = Convert.ToSingle(value);

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
                //value = PLC.Instance().VariableRead(nodeid);
                //LevelInSuctionTank_Filtered = Convert.ToSingle(value);

                //nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_EmptySuctionTank";
                //value = PLC.Instance().VariableRead(nodeid);
                //EmptySuctionTank = Convert.ToBoolean(value);

            }
            catch
            {

            }
        }

        #region Enter Key
        private void tbPumpRunDelay_KeyUp(object sender, KeyEventArgs e)
        {          
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbPumpRunDelay.Text != "")
                    {
                        ret = Utilities.TryParse(tbPumpRunDelay.Text, "Int32", out obj);
                        if (ret)
                        {
                            PumpRunDelay = (int)obj * 1000;
                        }
                    }
                    tbPumpRunDelay.Text = (PumpRunDelay / 1000).ToString();
                }
            }                          
        }

        private void tbAbove_Level_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbAbove_Level.Text != "")
                    {
                        ret = Utilities.TryParse(tbAbove_Level.Text, "Real", out obj);
                        if (ret)
                        {
                            Above_Level = (float)obj;
                        }
                    }
                    tbAbove_Level.Text = Above_Level.ToString();
                }
            }
        }

        private void tbBottom_Level_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbBottom_Level.Text != "")
                    {
                        ret = Utilities.TryParse(tbBottom_Level.Text, "Real", out obj);
                        if (ret)
                        {
                            Bottom_Level = (float)obj;
                        }
                    }
                    tbBottom_Level.Text = Bottom_Level.ToString();
                }
            }
        }    

        private void tbConveyerStopDelay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbConveyerStopDelay.Text != "")
                    {
                        ret = Utilities.TryParse(tbConveyerStopDelay.Text, "Int32", out obj);
                        if (ret)
                        {
                            ConveyerStopDelay = (int)obj * 1000;
                        }
                    }
                    tbConveyerStopDelay.Text = (ConveyerStopDelay / 1000).ToString();
                }           
            }
        }

        private void tbTimeLimit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbTimeLimit.Text != "")
                    {
                        ret = Utilities.TryParse(tbTimeLimit.Text, "Int32", out obj);
                        if (ret)
                        {
                            TimeLimit = (int)obj * 1000;
                        }
                    }
                    tbTimeLimit.Text = (TimeLimit / 1000).ToString();
                }
            }
        }

        private void tbMasterChangeFrequency_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbMasterChangeFrequency.Text != "")
                    {
                        ret = Utilities.TryParse(tbMasterChangeFrequency.Text, "Int32", out obj);
                        if (ret)
                        {
                            MasterChangeFrequency = (int)obj * 1000;
                        }
                    }
                    tbMasterChangeFrequency.Text = (MasterChangeFrequency / 1000).ToString();
                }
            }
        }

        private void tbRakerRunDelay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbRakerRunDelay.Text != "")
                    {
                        ret = Utilities.TryParse(tbRakerRunDelay.Text, "Int32", out obj);
                        if (ret)
                        {
                            RackerRunDelay = (int)obj * 1000;
                        }
                    }
                    tbRakerRunDelay.Text = (RackerRunDelay / 1000).ToString();
                }
            }
        }

        private void tbRakerStopDelay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult mb = MessageBox.Show("Do you want to change this value?", "Confirm", MessageBoxButtons.YesNo);
                if (mb == DialogResult.Yes)
                {
                    object obj;
                    bool ret;
                    if (tbRakerStopDelay.Text != "")
                    {
                        ret = Utilities.TryParse(tbRakerStopDelay.Text, "Int32", out obj);
                        if (ret)
                        {
                            RackerStopDelay = (int)obj * 1000;
                        }
                    }
                    tbRakerStopDelay.Text = (RackerStopDelay / 1000).ToString();
                }
            }
        }

        #endregion

        private void Page_General_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Page_General_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopTimer1();
        }
    }
}
