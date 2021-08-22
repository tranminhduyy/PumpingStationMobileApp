namespace Opc.Ua.Sample.Controls
{
    partial class Form_Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btLevel = new System.Windows.Forms.Button();
            this.mcLevel = new System.Windows.Forms.MonthCalendar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLevel = new System.Windows.Forms.TabPage();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btTemperature = new System.Windows.Forms.Button();
            this.mcTemperature = new System.Windows.Forms.MonthCalendar();
            this.tabHumidity = new System.Windows.Forms.TabPage();
            this.chartHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btHumidity = new System.Windows.Forms.Button();
            this.mcHumidity = new System.Windows.Forms.MonthCalendar();
            this.btRealtimeHumidity = new System.Windows.Forms.Button();
            this.timerHumidity = new System.Windows.Forms.Timer(this.components);
            this.btRealtimeTemperature = new System.Windows.Forms.Button();
            this.btRealtimeLevel = new System.Windows.Forms.Button();
            this.timerLevel = new System.Windows.Forms.Timer(this.components);
            this.timerTemperature = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartLevel)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabLevel.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.tabHumidity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLevel
            // 
            this.chartLevel.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartLevel.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartLevel.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartLevel.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea16.Name = "ChartArea1";
            this.chartLevel.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.chartLevel.Legends.Add(legend16);
            this.chartLevel.Location = new System.Drawing.Point(17, 143);
            this.chartLevel.Name = "chartLevel";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "LevelInSuctionTank_Filtered";
            this.chartLevel.Series.Add(series16);
            this.chartLevel.Size = new System.Drawing.Size(1063, 482);
            this.chartLevel.TabIndex = 1;
            this.chartLevel.Text = "chart1";
            // 
            // btLevel
            // 
            this.btLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLevel.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btLevel.Location = new System.Drawing.Point(1110, 317);
            this.btLevel.Name = "btLevel";
            this.btLevel.Size = new System.Drawing.Size(226, 42);
            this.btLevel.TabIndex = 4;
            this.btLevel.Text = "Search";
            this.btLevel.UseVisualStyleBackColor = false;
            this.btLevel.Click += new System.EventHandler(this.btSearchLevel_Click);
            // 
            // mcLevel
            // 
            this.mcLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mcLevel.Font = new System.Drawing.Font("Helvetica World", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcLevel.ForeColor = System.Drawing.Color.White;
            this.mcLevel.Location = new System.Drawing.Point(1109, 143);
            this.mcLevel.MaxSelectionCount = 31;
            this.mcLevel.Name = "mcLevel";
            this.mcLevel.ShowTodayCircle = false;
            this.mcLevel.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLevel);
            this.tabControl1.Controls.Add(this.tabTemperature);
            this.tabControl1.Controls.Add(this.tabHumidity);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 659);
            this.tabControl1.TabIndex = 5;
            // 
            // tabLevel
            // 
            this.tabLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.tabLevel.Controls.Add(this.btRealtimeLevel);
            this.tabLevel.Controls.Add(this.chartLevel);
            this.tabLevel.Controls.Add(this.btLevel);
            this.tabLevel.Controls.Add(this.mcLevel);
            this.tabLevel.Location = new System.Drawing.Point(4, 22);
            this.tabLevel.Name = "tabLevel";
            this.tabLevel.Padding = new System.Windows.Forms.Padding(3);
            this.tabLevel.Size = new System.Drawing.Size(1374, 633);
            this.tabLevel.TabIndex = 0;
            this.tabLevel.Text = "Level In Suction Tank";
            // 
            // tabTemperature
            // 
            this.tabTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.tabTemperature.Controls.Add(this.btRealtimeTemperature);
            this.tabTemperature.Controls.Add(this.chartTemperature);
            this.tabTemperature.Controls.Add(this.btTemperature);
            this.tabTemperature.Controls.Add(this.mcTemperature);
            this.tabTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemperature.Size = new System.Drawing.Size(1374, 633);
            this.tabTemperature.TabIndex = 1;
            this.tabTemperature.Text = "Temperature";
            // 
            // chartTemperature
            // 
            this.chartTemperature.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartTemperature.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartTemperature.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartTemperature.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea17.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend17);
            this.chartTemperature.Location = new System.Drawing.Point(17, 143);
            this.chartTemperature.Name = "chartTemperature";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "Temperature";
            this.chartTemperature.Series.Add(series17);
            this.chartTemperature.Size = new System.Drawing.Size(1063, 482);
            this.chartTemperature.TabIndex = 5;
            this.chartTemperature.Text = "chart1";
            // 
            // btTemperature
            // 
            this.btTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTemperature.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btTemperature.Location = new System.Drawing.Point(1110, 317);
            this.btTemperature.Name = "btTemperature";
            this.btTemperature.Size = new System.Drawing.Size(226, 42);
            this.btTemperature.TabIndex = 7;
            this.btTemperature.Text = "Search";
            this.btTemperature.UseVisualStyleBackColor = false;
            this.btTemperature.Click += new System.EventHandler(this.btTemperature_Click);
            // 
            // mcTemperature
            // 
            this.mcTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mcTemperature.Font = new System.Drawing.Font("Helvetica World", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcTemperature.ForeColor = System.Drawing.Color.White;
            this.mcTemperature.Location = new System.Drawing.Point(1109, 143);
            this.mcTemperature.MaxSelectionCount = 31;
            this.mcTemperature.Name = "mcTemperature";
            this.mcTemperature.ShowTodayCircle = false;
            this.mcTemperature.TabIndex = 6;
            // 
            // tabHumidity
            // 
            this.tabHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.tabHumidity.Controls.Add(this.btRealtimeHumidity);
            this.tabHumidity.Controls.Add(this.chartHumidity);
            this.tabHumidity.Controls.Add(this.btHumidity);
            this.tabHumidity.Controls.Add(this.mcHumidity);
            this.tabHumidity.Location = new System.Drawing.Point(4, 22);
            this.tabHumidity.Name = "tabHumidity";
            this.tabHumidity.Padding = new System.Windows.Forms.Padding(3);
            this.tabHumidity.Size = new System.Drawing.Size(1374, 633);
            this.tabHumidity.TabIndex = 2;
            this.tabHumidity.Text = "Humidity";
            // 
            // chartHumidity
            // 
            this.chartHumidity.BorderSkin.BackColor = System.Drawing.Color.White;
            this.chartHumidity.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chartHumidity.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chartHumidity.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
            chartArea18.Name = "ChartArea1";
            this.chartHumidity.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chartHumidity.Legends.Add(legend18);
            this.chartHumidity.Location = new System.Drawing.Point(17, 143);
            this.chartHumidity.Name = "chartHumidity";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "Humidity";
            this.chartHumidity.Series.Add(series18);
            this.chartHumidity.Size = new System.Drawing.Size(1063, 482);
            this.chartHumidity.TabIndex = 8;
            this.chartHumidity.Text = "chart1";
            // 
            // btHumidity
            // 
            this.btHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHumidity.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btHumidity.Location = new System.Drawing.Point(1110, 317);
            this.btHumidity.Name = "btHumidity";
            this.btHumidity.Size = new System.Drawing.Size(226, 42);
            this.btHumidity.TabIndex = 10;
            this.btHumidity.Text = "Search";
            this.btHumidity.UseVisualStyleBackColor = false;
            this.btHumidity.Click += new System.EventHandler(this.btHumidity_Click);
            // 
            // mcHumidity
            // 
            this.mcHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mcHumidity.Font = new System.Drawing.Font("Helvetica World", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcHumidity.ForeColor = System.Drawing.Color.White;
            this.mcHumidity.Location = new System.Drawing.Point(1109, 143);
            this.mcHumidity.MaxSelectionCount = 31;
            this.mcHumidity.Name = "mcHumidity";
            this.mcHumidity.ShowTodayCircle = false;
            this.mcHumidity.TabIndex = 9;
            // 
            // btRealtimeHumidity
            // 
            this.btRealtimeHumidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btRealtimeHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealtimeHumidity.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btRealtimeHumidity.Location = new System.Drawing.Point(1109, 424);
            this.btRealtimeHumidity.Name = "btRealtimeHumidity";
            this.btRealtimeHumidity.Size = new System.Drawing.Size(226, 42);
            this.btRealtimeHumidity.TabIndex = 11;
            this.btRealtimeHumidity.Text = "Start Realtime";
            this.btRealtimeHumidity.UseVisualStyleBackColor = false;
            this.btRealtimeHumidity.Click += new System.EventHandler(this.btRealtimeHumidity_Click);
            // 
            // timerHumidity
            // 
            this.timerHumidity.Interval = 2000;
            this.timerHumidity.Tick += new System.EventHandler(this.timerHumidity_Tick);
            // 
            // btRealtimeTemperature
            // 
            this.btRealtimeTemperature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btRealtimeTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealtimeTemperature.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btRealtimeTemperature.Location = new System.Drawing.Point(1109, 424);
            this.btRealtimeTemperature.Name = "btRealtimeTemperature";
            this.btRealtimeTemperature.Size = new System.Drawing.Size(226, 42);
            this.btRealtimeTemperature.TabIndex = 12;
            this.btRealtimeTemperature.Text = "Start Realtime";
            this.btRealtimeTemperature.UseVisualStyleBackColor = false;
            this.btRealtimeTemperature.Click += new System.EventHandler(this.btRealtimeTemperature_Click);
            // 
            // btRealtimeLevel
            // 
            this.btRealtimeLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btRealtimeLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRealtimeLevel.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btRealtimeLevel.Location = new System.Drawing.Point(1109, 424);
            this.btRealtimeLevel.Name = "btRealtimeLevel";
            this.btRealtimeLevel.Size = new System.Drawing.Size(226, 42);
            this.btRealtimeLevel.TabIndex = 12;
            this.btRealtimeLevel.Text = "Start Realtime";
            this.btRealtimeLevel.UseVisualStyleBackColor = false;
            this.btRealtimeLevel.Click += new System.EventHandler(this.btRealtimeLevel_Click);
            // 
            // timerLevel
            // 
            this.timerLevel.Interval = 2000;
            this.timerLevel.Tick += new System.EventHandler(this.timerLevel_Tick);
            // 
            // timerTemperature
            // 
            this.timerTemperature.Interval = 2000;
            this.timerTemperature.Tick += new System.EventHandler(this.timerTemperature_Tick);
            // 
            // Form_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1384, 661);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Chart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartLevel)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabLevel.ResumeLayout(false);
            this.tabTemperature.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.tabHumidity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHumidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLevel;
        private System.Windows.Forms.Button btLevel;
        private System.Windows.Forms.MonthCalendar mcLevel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLevel;
        private System.Windows.Forms.TabPage tabTemperature;
        private System.Windows.Forms.TabPage tabHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Button btTemperature;
        private System.Windows.Forms.MonthCalendar mcTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHumidity;
        private System.Windows.Forms.Button btHumidity;
        private System.Windows.Forms.MonthCalendar mcHumidity;
        private System.Windows.Forms.Button btRealtimeHumidity;
        private System.Windows.Forms.Timer timerHumidity;
        private System.Windows.Forms.Button btRealtimeLevel;
        private System.Windows.Forms.Button btRealtimeTemperature;
        private System.Windows.Forms.Timer timerLevel;
        private System.Windows.Forms.Timer timerTemperature;
    }
}