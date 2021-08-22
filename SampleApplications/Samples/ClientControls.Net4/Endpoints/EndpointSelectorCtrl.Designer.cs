/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 * 
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

namespace Opc.Ua.Client.Controls
{
    partial class EndpointSelectorCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectButton = new System.Windows.Forms.Button();
            this.EndpointCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(222)))), ((int)(((byte)(208)))));
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Helvetica World", 15F, System.Drawing.FontStyle.Bold);
            this.ConnectButton.Location = new System.Drawing.Point(2, 73);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(449, 48);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // EndpointCB
            // 
            this.EndpointCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EndpointCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            this.EndpointCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndpointCB.Font = new System.Drawing.Font("Helvetica World", 12F);
            this.EndpointCB.Items.AddRange(new object[] {
            "opc.tcp://45.124.94.180:4852"});
            this.EndpointCB.Location = new System.Drawing.Point(2, 2);
            this.EndpointCB.MaximumSize = new System.Drawing.Size(450, 0);
            this.EndpointCB.MinimumSize = new System.Drawing.Size(450, 0);
            this.EndpointCB.Name = "EndpointCB";
            this.EndpointCB.Size = new System.Drawing.Size(450, 38);
            this.EndpointCB.TabIndex = 0;
            this.EndpointCB.SelectedIndexChanged += new System.EventHandler(this.EndpointCB_SelectedIndexChanged);
            // 
            // EndpointSelectorCtrl
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.EndpointCB);
            this.Name = "EndpointSelectorCtrl";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Size = new System.Drawing.Size(454, 123);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ConnectButton;
        //private System.Windows.Forms.Panel ConnectPN;
        private System.Windows.Forms.ComboBox EndpointCB;
    }
}
