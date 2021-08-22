using System;
using System.Drawing;
using System.Windows.Forms;

namespace Opc.Ua.Sample.Controls
{
    public partial class Form_History : Form
    {
        public Form_History()
        {
            InitializeComponent();
        }

        private void Form_History_Load(object sender, EventArgs e)
        {
            mcHistory.BackColor = Color.FromArgb(40, 40, 40);
            mcHistory.ForeColor = Color.White;
            mcHistory.TrailingForeColor = System.Drawing.ColorTranslator.FromHtml("#3C3C3C");
            mcHistory.TitleBackColor = System.Drawing.ColorTranslator.FromHtml("#6662C3");
            mcHistory.TitleForeColor = Color.White;
            dgvHistory.Visible = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvHistory.Visible = true;
            SQL.Instance().Query_Data(mcHistory.SelectionRange.Start, mcHistory.SelectionRange.End);

            dgvHistory.DataSource = SQL.Instance().dt_Data;
            dgvHistory.Font = new System.Drawing.Font("Helvetica World", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvHistory.BorderStyle = BorderStyle.None;
            dgvHistory.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#303C48");
            dgvHistory.DefaultCellStyle.ForeColor = Color.White;
            dgvHistory.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#374451");
            dgvHistory.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.DefaultCellStyle.SelectionBackColor = System.Drawing.ColorTranslator.FromHtml("#717578");
            dgvHistory.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.ColumnHeadersHeight = 30;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#6662C3");
            dgvHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void btExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
