using System;
using System.IO;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_Communication : Form
    {
        public Form_Communication()
        {
            InitializeComponent();
        }

        private void Form_Communication_Load(object sender, EventArgs e)
        {
            tbIpAddress.Text = Properties.Settings.Default.IPPLC;
            tbSQL.Text       = Properties.Settings.Default.SQL;
            tbExcel.Text     = Properties.Settings.Default.Excel;
            tbUpdate.Text    = Properties.Settings.Default.UpdateTime.ToString();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IPPLC      = tbIpAddress.Text;
            Properties.Settings.Default.SQL        = tbSQL.Text;
            Properties.Settings.Default.Excel      = tbExcel.Text;
            Properties.Settings.Default.UpdateTime = int.Parse(tbUpdate.Text);

            MessageBox.Show("Save Completed! Please Restart Application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Properties.Settings.Default.Save();
            this.Close();
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals("1234"))
            {
                tbSQL.Enabled       = true;
                tbExcel.Enabled     = true;
                tbUpdate.Enabled    = true;
                btBrowse.Enabled    = true;
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
            }
            tbExcel.Text = folderPath;
            //MessageBox.Show(folderPath, "File Content at path: " + folderPath, MessageBoxButtons.OK);
        }
    }
}
