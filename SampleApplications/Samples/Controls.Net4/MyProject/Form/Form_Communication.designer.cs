namespace Opc.Ua.Sample.Controls
{
    partial class Form_Communication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Communication));
            this.cbStation = new System.Windows.Forms.ComboBox();
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.tbExcel = new System.Windows.Forms.TextBox();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btCheck = new System.Windows.Forms.Button();
            this.btBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbStation
            // 
            this.cbStation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.cbStation.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStation.FormattingEnabled = true;
            this.cbStation.Items.AddRange(new object[] {
            "TN 15",
            "TN 17-1"});
            this.cbStation.Location = new System.Drawing.Point(197, 186);
            this.cbStation.Name = "cbStation";
            this.cbStation.Size = new System.Drawing.Size(356, 35);
            this.cbStation.TabIndex = 0;
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.tbIpAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIpAddress.Enabled = false;
            this.tbIpAddress.Font = new System.Drawing.Font("Helvetica World", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddress.Location = new System.Drawing.Point(197, 236);
            this.tbIpAddress.Multiline = true;
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(356, 32);
            this.tbIpAddress.TabIndex = 2;
            // 
            // tbSQL
            // 
            this.tbSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.tbSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSQL.Enabled = false;
            this.tbSQL.Font = new System.Drawing.Font("Helvetica World", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSQL.Location = new System.Drawing.Point(197, 286);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.Size = new System.Drawing.Size(356, 32);
            this.tbSQL.TabIndex = 3;
            // 
            // tbExcel
            // 
            this.tbExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.tbExcel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbExcel.Enabled = false;
            this.tbExcel.Font = new System.Drawing.Font("Helvetica World", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExcel.Location = new System.Drawing.Point(197, 336);
            this.tbExcel.Multiline = true;
            this.tbExcel.Name = "tbExcel";
            this.tbExcel.Size = new System.Drawing.Size(244, 32);
            this.tbExcel.TabIndex = 4;
            this.tbExcel.Text = "D:\\ExcelStore";
            // 
            // tbUpdate
            // 
            this.tbUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.tbUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUpdate.Enabled = false;
            this.tbUpdate.Font = new System.Drawing.Font("Helvetica World", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUpdate.Location = new System.Drawing.Point(197, 388);
            this.tbUpdate.Multiline = true;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(356, 32);
            this.tbUpdate.TabIndex = 5;
            this.tbUpdate.Text = "300";
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSave.Font = new System.Drawing.Font("Helvetica World", 15F, System.Drawing.FontStyle.Bold);
            this.btSave.Location = new System.Drawing.Point(197, 463);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(356, 57);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "SAVE";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Helvetica World", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(197, 138);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '*';
            this.tbUser.Size = new System.Drawing.Size(244, 32);
            this.tbUser.TabIndex = 7;
            // 
            // btCheck
            // 
            this.btCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCheck.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btCheck.Location = new System.Drawing.Point(449, 136);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(104, 36);
            this.btCheck.TabIndex = 8;
            this.btCheck.Text = "Check";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
            // 
            // btBrowse
            // 
            this.btBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.btBrowse.Enabled = false;
            this.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBrowse.Font = new System.Drawing.Font("Helvetica World", 11F, System.Drawing.FontStyle.Bold);
            this.btBrowse.Location = new System.Drawing.Point(447, 334);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(104, 36);
            this.btBrowse.TabIndex = 9;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = false;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // Form_Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.btCheck);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbUpdate);
            this.Controls.Add(this.tbExcel);
            this.Controls.Add(this.tbSQL);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.cbStation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_Communication";
            this.Text = "Communication";
            this.Load += new System.EventHandler(this.Form_Communication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbStation;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.TextBox tbSQL;
        private System.Windows.Forms.TextBox tbExcel;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.Button btBrowse;
    }
}