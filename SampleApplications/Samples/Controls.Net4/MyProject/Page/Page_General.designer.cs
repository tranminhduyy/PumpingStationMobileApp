namespace Opc.Ua.Sample.Controls
{
    partial class Page_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_General));
            this.tbBottom_Level = new System.Windows.Forms.TextBox();
            this.tbAbove_Level = new System.Windows.Forms.TextBox();
            this.tbConveyerStopDelay = new System.Windows.Forms.TextBox();
            this.cbGlobalMode = new System.Windows.Forms.ComboBox();
            this.tbPumpRunDelay = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbLevelInSuctionTank_Filtered = new System.Windows.Forms.TextBox();
            this.tbRakerStopDelay = new System.Windows.Forms.TextBox();
            this.tbRakerRunDelay = new System.Windows.Forms.TextBox();
            this.tbMasterChangeFrequency = new System.Windows.Forms.TextBox();
            this.tbTimeLimit = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbEmptySuctionTank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmptySuctionTank)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBottom_Level
            // 
            this.tbBottom_Level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbBottom_Level.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBottom_Level.ForeColor = System.Drawing.Color.Yellow;
            this.tbBottom_Level.Location = new System.Drawing.Point(587, 404);
            this.tbBottom_Level.Margin = new System.Windows.Forms.Padding(2);
            this.tbBottom_Level.Multiline = true;
            this.tbBottom_Level.Name = "tbBottom_Level";
            this.tbBottom_Level.Size = new System.Drawing.Size(95, 28);
            this.tbBottom_Level.TabIndex = 93;
            this.tbBottom_Level.Text = "50";
            this.tbBottom_Level.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBottom_Level_KeyUp);
            // 
            // tbAbove_Level
            // 
            this.tbAbove_Level.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAbove_Level.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAbove_Level.ForeColor = System.Drawing.Color.Yellow;
            this.tbAbove_Level.Location = new System.Drawing.Point(587, 363);
            this.tbAbove_Level.Margin = new System.Windows.Forms.Padding(2);
            this.tbAbove_Level.Multiline = true;
            this.tbAbove_Level.Name = "tbAbove_Level";
            this.tbAbove_Level.Size = new System.Drawing.Size(95, 28);
            this.tbAbove_Level.TabIndex = 92;
            this.tbAbove_Level.Text = "100";
            this.tbAbove_Level.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAbove_Level_KeyUp);
            // 
            // tbConveyerStopDelay
            // 
            this.tbConveyerStopDelay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbConveyerStopDelay.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConveyerStopDelay.ForeColor = System.Drawing.Color.Yellow;
            this.tbConveyerStopDelay.Location = new System.Drawing.Point(587, 532);
            this.tbConveyerStopDelay.Margin = new System.Windows.Forms.Padding(2);
            this.tbConveyerStopDelay.Multiline = true;
            this.tbConveyerStopDelay.Name = "tbConveyerStopDelay";
            this.tbConveyerStopDelay.Size = new System.Drawing.Size(95, 28);
            this.tbConveyerStopDelay.TabIndex = 95;
            this.tbConveyerStopDelay.Text = "5";
            this.tbConveyerStopDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbConveyerStopDelay_KeyUp);
            // 
            // cbGlobalMode
            // 
            this.cbGlobalMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGlobalMode.FormattingEnabled = true;
            this.cbGlobalMode.Items.AddRange(new object[] {
            "Manual",
            "Auto",
            "Semi-Auto",
            "Service"});
            this.cbGlobalMode.Location = new System.Drawing.Point(390, 119);
            this.cbGlobalMode.Name = "cbGlobalMode";
            this.cbGlobalMode.Size = new System.Drawing.Size(108, 21);
            this.cbGlobalMode.TabIndex = 101;
            this.cbGlobalMode.SelectedIndexChanged += new System.EventHandler(this.cbGlobalMode_SelectedIndexChanged);
            // 
            // tbPumpRunDelay
            // 
            this.tbPumpRunDelay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbPumpRunDelay.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPumpRunDelay.ForeColor = System.Drawing.Color.Yellow;
            this.tbPumpRunDelay.Location = new System.Drawing.Point(587, 488);
            this.tbPumpRunDelay.Margin = new System.Windows.Forms.Padding(2);
            this.tbPumpRunDelay.Multiline = true;
            this.tbPumpRunDelay.Name = "tbPumpRunDelay";
            this.tbPumpRunDelay.Size = new System.Drawing.Size(95, 28);
            this.tbPumpRunDelay.TabIndex = 115;
            this.tbPumpRunDelay.Text = "5";
            this.tbPumpRunDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPumpRunDelay_KeyUp);
            // 
            // tbHumidity
            // 
            this.tbHumidity.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbHumidity.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbHumidity.Location = new System.Drawing.Point(220, 270);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(2);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(95, 28);
            this.tbHumidity.TabIndex = 120;
            // 
            // tbTemperature
            // 
            this.tbTemperature.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTemperature.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbTemperature.Location = new System.Drawing.Point(220, 224);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(95, 28);
            this.tbTemperature.TabIndex = 119;
            // 
            // tbLevelInSuctionTank_Filtered
            // 
            this.tbLevelInSuctionTank_Filtered.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbLevelInSuctionTank_Filtered.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLevelInSuctionTank_Filtered.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbLevelInSuctionTank_Filtered.Location = new System.Drawing.Point(587, 224);
            this.tbLevelInSuctionTank_Filtered.Margin = new System.Windows.Forms.Padding(2);
            this.tbLevelInSuctionTank_Filtered.Multiline = true;
            this.tbLevelInSuctionTank_Filtered.Name = "tbLevelInSuctionTank_Filtered";
            this.tbLevelInSuctionTank_Filtered.Size = new System.Drawing.Size(95, 28);
            this.tbLevelInSuctionTank_Filtered.TabIndex = 128;
            // 
            // tbRakerStopDelay
            // 
            this.tbRakerStopDelay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbRakerStopDelay.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRakerStopDelay.ForeColor = System.Drawing.Color.Yellow;
            this.tbRakerStopDelay.Location = new System.Drawing.Point(587, 698);
            this.tbRakerStopDelay.Margin = new System.Windows.Forms.Padding(2);
            this.tbRakerStopDelay.Multiline = true;
            this.tbRakerStopDelay.Name = "tbRakerStopDelay";
            this.tbRakerStopDelay.Size = new System.Drawing.Size(95, 28);
            this.tbRakerStopDelay.TabIndex = 136;
            this.tbRakerStopDelay.Text = "5";
            this.tbRakerStopDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRakerStopDelay_KeyUp);
            // 
            // tbRakerRunDelay
            // 
            this.tbRakerRunDelay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbRakerRunDelay.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRakerRunDelay.ForeColor = System.Drawing.Color.Yellow;
            this.tbRakerRunDelay.Location = new System.Drawing.Point(587, 657);
            this.tbRakerRunDelay.Margin = new System.Windows.Forms.Padding(2);
            this.tbRakerRunDelay.Multiline = true;
            this.tbRakerRunDelay.Name = "tbRakerRunDelay";
            this.tbRakerRunDelay.Size = new System.Drawing.Size(95, 28);
            this.tbRakerRunDelay.TabIndex = 135;
            this.tbRakerRunDelay.Text = "5";
            this.tbRakerRunDelay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbRakerRunDelay_KeyUp);
            // 
            // tbMasterChangeFrequency
            // 
            this.tbMasterChangeFrequency.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbMasterChangeFrequency.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasterChangeFrequency.ForeColor = System.Drawing.Color.Yellow;
            this.tbMasterChangeFrequency.Location = new System.Drawing.Point(587, 614);
            this.tbMasterChangeFrequency.Margin = new System.Windows.Forms.Padding(2);
            this.tbMasterChangeFrequency.Multiline = true;
            this.tbMasterChangeFrequency.Name = "tbMasterChangeFrequency";
            this.tbMasterChangeFrequency.Size = new System.Drawing.Size(95, 28);
            this.tbMasterChangeFrequency.TabIndex = 134;
            this.tbMasterChangeFrequency.Text = "60";
            this.tbMasterChangeFrequency.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbMasterChangeFrequency_KeyUp);
            // 
            // tbTimeLimit
            // 
            this.tbTimeLimit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbTimeLimit.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimeLimit.ForeColor = System.Drawing.Color.Yellow;
            this.tbTimeLimit.Location = new System.Drawing.Point(587, 573);
            this.tbTimeLimit.Margin = new System.Windows.Forms.Padding(2);
            this.tbTimeLimit.Multiline = true;
            this.tbTimeLimit.Name = "tbTimeLimit";
            this.tbTimeLimit.Size = new System.Drawing.Size(95, 28);
            this.tbTimeLimit.TabIndex = 133;
            this.tbTimeLimit.Text = "30";
            this.tbTimeLimit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTimeLimit_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbEmptySuctionTank
            // 
            this.pbEmptySuctionTank.BackColor = System.Drawing.Color.Transparent;
            this.pbEmptySuctionTank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEmptySuctionTank.BackgroundImage")));
            this.pbEmptySuctionTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEmptySuctionTank.Location = new System.Drawing.Point(617, 266);
            this.pbEmptySuctionTank.Margin = new System.Windows.Forms.Padding(2);
            this.pbEmptySuctionTank.Name = "pbEmptySuctionTank";
            this.pbEmptySuctionTank.Size = new System.Drawing.Size(37, 37);
            this.pbEmptySuctionTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmptySuctionTank.TabIndex = 151;
            this.pbEmptySuctionTank.TabStop = false;
            // 
            // Page_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 761);
            this.Controls.Add(this.tbAbove_Level);
            this.Controls.Add(this.tbRakerStopDelay);
            this.Controls.Add(this.cbGlobalMode);
            this.Controls.Add(this.tbBottom_Level);
            this.Controls.Add(this.pbEmptySuctionTank);
            this.Controls.Add(this.tbRakerRunDelay);
            this.Controls.Add(this.tbMasterChangeFrequency);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbPumpRunDelay);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTimeLimit);
            this.Controls.Add(this.tbLevelInSuctionTank_Filtered);
            this.Controls.Add(this.tbConveyerStopDelay);
            this.DoubleBuffered = true;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "Page_General";
            this.Text = "Page_General";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page_General_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Page_General_FormClosed);
            this.Load += new System.EventHandler(this.Page_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEmptySuctionTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbBottom_Level;
        private System.Windows.Forms.TextBox tbAbove_Level;
        private System.Windows.Forms.TextBox tbConveyerStopDelay;
        private System.Windows.Forms.ComboBox cbGlobalMode;
        private System.Windows.Forms.TextBox tbPumpRunDelay;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbLevelInSuctionTank_Filtered;
        private System.Windows.Forms.TextBox tbRakerStopDelay;
        private System.Windows.Forms.TextBox tbRakerRunDelay;
        private System.Windows.Forms.TextBox tbMasterChangeFrequency;
        private System.Windows.Forms.TextBox tbTimeLimit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbEmptySuctionTank;
    }
}