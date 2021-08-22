using System;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_AlarmSQL : Form
    {
        public Form_AlarmSQL()
        {
            InitializeComponent();
        }

        private void Form_AlarmSQL_Load(object sender, EventArgs e)
        {
            if (SQL.Instance().SQL_Connected)
            {
                lbSQL_Status.Text = "Running";
            }
            else
            {
                lbSQL_Status.Text = "Stopping";
            }
        }
    }
}
