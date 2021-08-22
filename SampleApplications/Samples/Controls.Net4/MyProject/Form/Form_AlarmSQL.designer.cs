namespace Opc.Ua.Sample.Controls
{
    partial class Form_AlarmSQL
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
            this.lbSQL_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSQL_Status
            // 
            this.lbSQL_Status.AutoSize = true;
            this.lbSQL_Status.Location = new System.Drawing.Point(106, 90);
            this.lbSQL_Status.Name = "lbSQL_Status";
            this.lbSQL_Status.Size = new System.Drawing.Size(35, 13);
            this.lbSQL_Status.TabIndex = 0;
            this.lbSQL_Status.Text = "label1";
            // 
            // Form_AlarmSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbSQL_Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form_AlarmSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlarmSQL";
            this.Load += new System.EventHandler(this.Form_AlarmSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSQL_Status;
    }
}