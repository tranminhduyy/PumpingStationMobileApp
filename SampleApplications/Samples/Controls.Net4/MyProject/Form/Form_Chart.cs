using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_Chart : Form
    {
        public Form_Chart()
        {
            InitializeComponent();
        }

        private void Form_Chart_Load(object sender, EventArgs e)
        {
            
        }

        private void btSearchLevel_Click(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartLevel(mcLevel.SelectionRange.Start, mcLevel.SelectionRange.End);
            chartLevel.DataSource = SQL.Instance().dt_ChartLevel;

            chartLevel.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartLevel.ChartAreas["ChartArea1"].AxisY.Title = "Level In SuctionTank";

            chartLevel.Series["LevelInSuctionTank_Filtered"].YValueMembers = "LEVELINSUCTIONTANK_FILTERED";
            chartLevel.Series["LevelInSuctionTank_Filtered"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartLevel.Series["LevelInSuctionTank_Filtered"].XValueMember = "TIME";
            chartLevel.Series["LevelInSuctionTank_Filtered"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void btTemperature_Click(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartTemperature(mcTemperature.SelectionRange.Start, mcTemperature.SelectionRange.End);
            chartTemperature.DataSource = SQL.Instance().dt_ChartTemperature;

            chartTemperature.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartTemperature.ChartAreas["ChartArea1"].AxisY.Title = "Temperature";

            chartTemperature.Series["Temperature"].YValueMembers = "TEMPERATURE";
            chartTemperature.Series["Temperature"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartTemperature.Series["Temperature"].XValueMember = "TIME";
            chartTemperature.Series["Temperature"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void btHumidity_Click(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartHumidity(mcHumidity.SelectionRange.Start, mcHumidity.SelectionRange.End);
            chartHumidity.DataSource = SQL.Instance().dt_ChartHumidity;

            chartHumidity.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartHumidity.ChartAreas["ChartArea1"].AxisY.Title = "Humidity";

            chartHumidity.Series["Humidity"].YValueMembers = "HUMIDITY";
            chartHumidity.Series["Humidity"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartHumidity.Series["Humidity"].XValueMember = "TIME";
            chartHumidity.Series["Humidity"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        bool realtimeHumidity;
        bool realtimeTemperature;
        bool realtimeLevel;

        private void btRealtimeLevel_Click(object sender, EventArgs e)
        {
            realtimeLevel = !realtimeLevel;
            if (realtimeLevel)
            {
                btRealtimeLevel.Text = "Stop Realtime";
                timerLevel.Enabled = true;
            }
            else
            {
                btRealtimeLevel.Text = "Start Realtime";
                timerLevel.Enabled = false;
            }
        }
        private void timerLevel_Tick(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartLevel(mcLevel.SelectionRange.Start, mcLevel.SelectionRange.End);
            chartLevel.DataSource = SQL.Instance().dt_ChartLevel;

            chartLevel.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartLevel.ChartAreas["ChartArea1"].AxisY.Title = "Level In SuctionTank";

            chartLevel.Series["LevelInSuctionTank_Filtered"].YValueMembers = "LEVELINSUCTIONTANK_FILTERED";
            chartLevel.Series["LevelInSuctionTank_Filtered"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartLevel.Series["LevelInSuctionTank_Filtered"].XValueMember = "TIME";
            chartLevel.Series["LevelInSuctionTank_Filtered"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void btRealtimeTemperature_Click(object sender, EventArgs e)
        {
            realtimeTemperature = !realtimeTemperature;
            if (realtimeTemperature)
            {
                btRealtimeTemperature.Text = "Stop Realtime";
                timerTemperature.Enabled = true;
            }
            else
            {
                btRealtimeTemperature.Text = "Start Realtime";
                timerTemperature.Enabled = false;
            }
        }
        private void timerTemperature_Tick(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartTemperature(mcTemperature.SelectionRange.Start, mcTemperature.SelectionRange.End);
            chartTemperature.DataSource = SQL.Instance().dt_ChartTemperature;

            chartTemperature.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartTemperature.ChartAreas["ChartArea1"].AxisY.Title = "Temperature";

            chartTemperature.Series["Temperature"].YValueMembers = "TEMPERATURE";
            chartTemperature.Series["Temperature"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartTemperature.Series["Temperature"].XValueMember = "TIME";
            chartTemperature.Series["Temperature"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }

        private void btRealtimeHumidity_Click(object sender, EventArgs e)
        {
            realtimeHumidity = !realtimeHumidity;
            if (realtimeHumidity)
            {
                btRealtimeHumidity.Text = "Stop Realtime";
                timerHumidity.Enabled = true;
            }
            else
            {
                btRealtimeHumidity.Text = "Start Realtime";
                timerHumidity.Enabled = false;
            }
        }

        private void timerHumidity_Tick(object sender, EventArgs e)
        {
            SQL.Instance().Query_ChartHumidity(mcHumidity.SelectionRange.Start, mcHumidity.SelectionRange.End);
            chartHumidity.DataSource = SQL.Instance().dt_ChartHumidity;

            chartHumidity.ChartAreas["ChartArea1"].AxisX.Title = "Time";
            chartHumidity.ChartAreas["ChartArea1"].AxisY.Title = "Humidity";

            chartHumidity.Series["Humidity"].YValueMembers = "HUMIDITY";
            chartHumidity.Series["Humidity"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            chartHumidity.Series["Humidity"].XValueMember = "TIME";
            chartHumidity.Series["Humidity"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        }
    }
}
