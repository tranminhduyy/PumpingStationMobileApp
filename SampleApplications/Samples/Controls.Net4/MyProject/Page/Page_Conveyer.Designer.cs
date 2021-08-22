namespace Opc.Ua.Sample.Controls
{
    partial class Page_Conveyer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Page_Conveyer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btReset = new System.Windows.Forms.CheckBox();
            this.btStop = new System.Windows.Forms.CheckBox();
            this.btStart = new System.Windows.Forms.CheckBox();
            this.pbFault = new System.Windows.Forms.PictureBox();
            this.pbRunFeedback = new System.Windows.Forms.PictureBox();
            this.tbFaultID = new System.Windows.Forms.TextBox();
            this.tbMode = new System.Windows.Forms.TextBox();
            this.btCheckFaultID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btReset
            // 
            this.btReset.Appearance = System.Windows.Forms.Appearance.Button;
            this.btReset.BackColor = System.Drawing.Color.Transparent;
            this.btReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btReset.BackgroundImage")));
            this.btReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReset.FlatAppearance.BorderSize = 0;
            this.btReset.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Location = new System.Drawing.Point(426, 234);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(87, 87);
            this.btReset.TabIndex = 124;
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.CheckedChanged += new System.EventHandler(this.btReset_CheckedChanged);
            // 
            // btStop
            // 
            this.btStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.btStop.BackColor = System.Drawing.Color.Transparent;
            this.btStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStop.BackgroundImage")));
            this.btStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStop.FlatAppearance.BorderSize = 0;
            this.btStop.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.Location = new System.Drawing.Point(248, 234);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(87, 87);
            this.btStop.TabIndex = 123;
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.CheckedChanged += new System.EventHandler(this.btStop_CheckedChanged);
            // 
            // btStart
            // 
            this.btStart.Appearance = System.Windows.Forms.Appearance.Button;
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btStart.BackgroundImage")));
            this.btStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btStart.Enabled = false;
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Location = new System.Drawing.Point(68, 234);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(87, 87);
            this.btStart.TabIndex = 122;
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.CheckedChanged += new System.EventHandler(this.btStart_CheckedChanged);
            // 
            // pbFault
            // 
            this.pbFault.BackColor = System.Drawing.Color.Transparent;
            this.pbFault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFault.BackgroundImage")));
            this.pbFault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFault.Location = new System.Drawing.Point(155, 480);
            this.pbFault.Margin = new System.Windows.Forms.Padding(2);
            this.pbFault.Name = "pbFault";
            this.pbFault.Size = new System.Drawing.Size(37, 37);
            this.pbFault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFault.TabIndex = 118;
            this.pbFault.TabStop = false;
            // 
            // pbRunFeedback
            // 
            this.pbRunFeedback.BackColor = System.Drawing.Color.Transparent;
            this.pbRunFeedback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRunFeedback.BackgroundImage")));
            this.pbRunFeedback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRunFeedback.Location = new System.Drawing.Point(433, 386);
            this.pbRunFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.pbRunFeedback.Name = "pbRunFeedback";
            this.pbRunFeedback.Size = new System.Drawing.Size(37, 37);
            this.pbRunFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRunFeedback.TabIndex = 116;
            this.pbRunFeedback.TabStop = false;
            // 
            // tbFaultID
            // 
            this.tbFaultID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbFaultID.Font = new System.Drawing.Font("Seven Segment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFaultID.ForeColor = System.Drawing.Color.GreenYellow;
            this.tbFaultID.Location = new System.Drawing.Point(400, 484);
            this.tbFaultID.Margin = new System.Windows.Forms.Padding(2);
            this.tbFaultID.Multiline = true;
            this.tbFaultID.Name = "tbFaultID";
            this.tbFaultID.Size = new System.Drawing.Size(103, 33);
            this.tbFaultID.TabIndex = 115;
            // 
            // tbMode
            // 
            this.tbMode.Location = new System.Drawing.Point(236, 113);
            this.tbMode.Multiline = true;
            this.tbMode.Name = "tbMode";
            this.tbMode.Size = new System.Drawing.Size(122, 24);
            this.tbMode.TabIndex = 125;
            // 
            // btCheckFaultID
            // 
            this.btCheckFaultID.BackColor = System.Drawing.Color.Transparent;
            this.btCheckFaultID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCheckFaultID.BackgroundImage")));
            this.btCheckFaultID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckFaultID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheckFaultID.Location = new System.Drawing.Point(512, 483);
            this.btCheckFaultID.Name = "btCheckFaultID";
            this.btCheckFaultID.Size = new System.Drawing.Size(35, 35);
            this.btCheckFaultID.TabIndex = 134;
            this.btCheckFaultID.UseVisualStyleBackColor = false;
            this.btCheckFaultID.Click += new System.EventHandler(this.btCheckFaultID_Click);
            // 
            // Page_Conveyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btCheckFaultID);
            this.Controls.Add(this.tbMode);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbFault);
            this.Controls.Add(this.pbRunFeedback);
            this.Controls.Add(this.tbFaultID);
            this.DoubleBuffered = true;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.Name = "Page_Conveyer";
            this.Text = "Page_Conveyer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Page_Conveyer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Page_Conveyer_FormClosed);
            this.Load += new System.EventHandler(this.Page_Conveyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRunFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox btReset;
        private System.Windows.Forms.CheckBox btStop;
        private System.Windows.Forms.CheckBox btStart;
        private System.Windows.Forms.PictureBox pbFault;
        private System.Windows.Forms.PictureBox pbRunFeedback;
        private System.Windows.Forms.TextBox tbFaultID;
        private System.Windows.Forms.TextBox tbMode;
        private System.Windows.Forms.Button btCheckFaultID;
    }
}