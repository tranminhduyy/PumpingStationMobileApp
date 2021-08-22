using System;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Data.Instance().Liquidate();
                ExportExcel.Instance().Liquidate();
                e.Cancel = true;
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            communicationToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            Properties.Settings.Default.User = "";
            Properties.Settings.Default.Save();
            tsUser.Text = Properties.Settings.Default.User;

            statusStrip.Enabled = false;

            timerMain.Enabled = true;
            SQL.Instance().TestConnection();
            Data.Instance().Run();
            ExportExcel.Instance().Run();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Menu
        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Communication fr = new Form_Communication();
            fr.ShowDialog();
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Chart fr = new Form_Chart();
            fr.ShowDialog();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_History fr = new Form_History();
            fr.ShowDialog();
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AlarmSQL fr = new Form_AlarmSQL();
            fr.ShowDialog();
        }

        private void pLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form_AlarmPLC fr = new Form_AlarmPLC();
            //fr.ShowDialog();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_About fr = new Form_About();
            fr.ShowDialog();
        }
       
        private void pumpStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPagePumpStation mpps = new MainPagePumpStation();
            mpps.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.ShowDialog();

            if (Properties.Settings.Default.User.Equals("Engineer") || Properties.Settings.Default.User.Equals("Admin"))
            {
                tsUser.Text = Properties.Settings.Default.User;
                communicationToolStripMenuItem.Enabled = true;
                logoutToolStripMenuItem.Enabled = true;
                loginToolStripMenuItem.Enabled = false;
                statusStrip.Enabled = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            communicationToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
            loginToolStripMenuItem.Enabled = true;
            Properties.Settings.Default.User = "";
            Properties.Settings.Default.Save();
            tsUser.Text = Properties.Settings.Default.User;
            statusStrip.Enabled = false;
        }
        #endregion

        private void timerMain_Tick(object sender, EventArgs e)
        {
            timerMain.Interval = Properties.Settings.Default.UpdateTime;
            if (PLC.Instance().IsConnected())
            {
                tsPLC_Status.Text = "PLC Running";
            }
            else
            {
                tsPLC_Status.Text = "PLC Stop";
            }

            SQL.Instance().Insert_Data();
        }
    }
}
