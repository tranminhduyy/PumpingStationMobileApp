using System;
using System.Windows.Forms;
using System.Threading;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUser.Text.Equals("Admin") && tbPass.Text.Equals("ad"))
            {
                Properties.Settings.Default.User = "Admin";
                Properties.Settings.Default.Pass = "ad";
                Properties.Settings.Default.Save();

                this.Close();
            }
            else if (tbUser.Text.Equals("Engineer") && tbPass.Text.Equals("en"))
            {
                Properties.Settings.Default.User = "Engineer";
                Properties.Settings.Default.Pass = "en";
                Properties.Settings.Default.Save();

                this.Close();
            }
            else
            {
                MessageBox.Show("Login Error");
            }
        }
    }
}
