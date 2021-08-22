using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Drawing;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Opc.Ua.Sample.Controls
{
    public class ExportExcel
    {
        protected ExportExcel()
        {

        }

        private static ExportExcel _instance;
        public static ExportExcel Instance()
        {
            if (_instance == null)
            {
                _instance = new ExportExcel();
            }
            return _instance;
        }

        public int Period = 10000;
        System.Timers.Timer MainTimer = null;
        Thread TaskThread;

        public void Liquidate()
        {
            StopTimer();
        }

        public void StopTimer()      // Dừng hẳn Task
        {
            if (MainTimer != null)
            {
                MainTimer.Dispose();
                MainTimer = null;
            }
        }

        public void Run()
        {
            TaskThread = new Thread(ThreadRun);
            TaskThread.Priority = ThreadPriority.Normal;
            TaskThread.Start();
        }

        void ThreadRun()        // Chạy Task
        {
            if (MainTimer == null)
            {
                MainTimer = new System.Timers.Timer(Period);
                MainTimer.AutoReset = true;
                MainTimer.Elapsed += new System.Timers.ElapsedEventHandler(TimerElapsed);
                MainTimer.Start();
            }
        }

        static System.DateTime TimeStamp;
        static int Day_Prev = -1;

        static SqlConnection cnn = new SqlConnection(@"Data Source=TTBTECH;Initial Catalog=PumpStation;Integrated Security=True");
        private static void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            TimeStamp = DateTime.Now;

            if ((TimeStamp.Day - Day_Prev) != 0)
            {
                DateTime thoigian = DateTime.Now;
                if (SQL.Instance().SQL_Connected)
                {
                    cnn.Open();
                    string sql;
                    if (thoigian.Day == 1)
                    {
                        sql = "use PumpStation delete from DAILY declare @dateb datetime set @dateb = getdate() declare @start date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-1, @dateb-1) declare @end date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-1, @dateb-1) insert into DAILY select * from TABLE_SCADA where DATE between @start and @end select * from DAILY";
                    }
                    else
                    {
                        sql = "use PumpStation delete from DAILY declare @dateb datetime set @dateb = getdate() declare @start date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1) declare @end date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1) insert into DAILY select * from TABLE_SCADA where DATE between @start and @end select * from DAILY";
                    }
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        System.Data.DataTable dt = new System.Data.DataTable();
                        dt.Clear();
                        da.Fill(dt);
                    }
                    cnn.Close();
                }
                //cnn.Open();
                //string sql;
                //if (thoigian.Day == 1)
                //{
                //    sql = "use PumpStation delete from DAILY declare @dateb datetime set @dateb = getdate() declare @start date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-1, @dateb-1) declare @end date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-1, @dateb-1) insert into DAILY select * from TABLE_SCADA where DATE between @start and @end select * from DAILY";
                //}
                //else
                //{
                //    sql = "use PumpStation delete from DAILY declare @dateb datetime set @dateb = getdate() declare @start date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1) declare @end date = DATEADD(MONTH, DATEDIFF(MONTH, @dateb-1, GETDATE())-0, @dateb-1) insert into DAILY select * from TABLE_SCADA where DATE between @start and @end select * from DAILY";
                //}
                //MessageBox.Show("aaa");
                //SqlCommand com = new SqlCommand(sql, cnn); //bat dau truy van
                //com.CommandType = CommandType.Text;
                //SqlDataAdapter da = new SqlDataAdapter(com);
                ////cnn.Close();
                EXPORT_EXCEL_day();
            }
        }

        static string curfile = "";
        static string path = "";
        static void EXPORT_EXCEL_day()
        {
            Day_Prev = TimeStamp.Day;
            try
            {
                DateTime TimeStamp = DateTime.Now;
                Excel.Application xlApp = new Excel.Application();
                path = Properties.Settings.Default.Excel;
                curfile = path + "\\" + (TimeStamp.Year.ToString() + "_" + TimeStamp.Month.ToString() + "_" + TimeStamp.Day.ToString()
                                                + "_" + TimeStamp.Hour.ToString() + "_" + TimeStamp.Minute.ToString() + "_" + TimeStamp.Second) + ".xlsx";
            MessageBox.Show(curfile);
            if (xlApp == null)
            {
                MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                return;
            }
            xlApp.Visible = false;

            object misValue = System.Reflection.Missing.Value;

            Workbook wb = xlApp.Workbooks.Add(misValue);

            string fontName = "Helvetica World";
            int fontSizeTieuDe = 18;
            int fontSizeTenTruong = 14;
            int fontSizeNoiDung = 10;
            string day = DateTime.Today.AddDays(-1).ToString("MM/dd/yyyy");

            #region Object
            Worksheet wsObject = (Worksheet)wb.Worksheets[1];

            wsObject.Name = "Thiết bị";

            if (wsObject == null)
            {
                MessageBox.Show("Không thể tạo được WorkSheet");
                return;
            }
            int row_Object;

            Excel.Range TRUONG_Object = wsObject.get_Range("A1", "T1");
            TRUONG_Object.Merge();
            TRUONG_Object.Font.Size = fontSizeTieuDe;
            TRUONG_Object.Font.Name = fontName;
            TRUONG_Object.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            TRUONG_Object.Value2 = "TRƯỜNG ĐẠI HỌC BÁCH KHOA THÀNH PHỐ HỒ CHÍ MINH";

            Excel.Range BOMON_Object = wsObject.get_Range("A2", "T2");
            BOMON_Object.Merge();
            BOMON_Object.Font.Size = fontSizeTieuDe;
            BOMON_Object.Font.Name = fontName;
            BOMON_Object.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            BOMON_Object.Value2 = "Bộ môn Kỹ thuật Điều khiển và Tự Động Hóa";

            Excel.Range row3_Object = wsObject.get_Range("A3", "T3");
            row3_Object.Merge();
            row3_Object.Font.Size = fontSizeTieuDe;
            row3_Object.Font.Name = fontName;
            row3_Object.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
            row3_Object.Value2 = "File báo cáo ngày " + day;

            Excel.Range row23_Object = wsObject.get_Range("A1", "T2");
            row23_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#02A8EB"));
            row23_Object.Font.Bold = true;
            row23_Object.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

            Excel.Range row23_ten_Object = wsObject.get_Range("A3", "T3");
            row23_ten_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.GreenYellow);
            row23_ten_Object.Font.Bold = true;
            row23_ten_Object.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

            Excel.Range row4_Object = wsObject.get_Range("A4", "T4");
            row4_Object.Merge();
            row4_Object.Font.Size = fontSizeTieuDe;
            row4_Object.Font.Name = fontName;
            row4_Object.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
            row4_Object.Value2 = "Thiết bị";
            row4_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
            row4_Object.Font.Bold = true;
            row4_Object.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

            Excel.Range row5_ID_Object = wsObject.get_Range("A5");
            row5_ID_Object.Font.Size = fontSizeTenTruong;
            row5_ID_Object.Font.Name = fontName;
            row5_ID_Object.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_ID_Object.Value2 = "ID";
                row5_ID_Object.ColumnWidth = 20;

            Excel.Range row5_time = wsObject.get_Range("B5");
            row5_time.Font.Size = fontSizeTenTruong;
            row5_time.Font.Name = fontName;
            row5_time.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_time.Value2 = "Thời gian";
            row5_time.ColumnWidth = 15;

            Excel.Range row5_Pump_1_RunFeedback = wsObject.get_Range("C5");
            row5_Pump_1_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Pump_1_RunFeedback.Font.Name = fontName;
            row5_Pump_1_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_1_RunFeedback.Value2 = "Trạng thái bơm 1";
            row5_Pump_1_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Pump_1_FaultID = wsObject.get_Range("D5");
            row5_Pump_1_FaultID.Font.Size = fontSizeTenTruong;
            row5_Pump_1_FaultID.Font.Name = fontName;
            row5_Pump_1_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_1_FaultID.Value2 = "Mã lỗi bơm 1";
            row5_Pump_1_FaultID.ColumnWidth = 30;

            Excel.Range row5_Pump_2_RunFeedback = wsObject.get_Range("E5");
            row5_Pump_2_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Pump_2_RunFeedback.Font.Name = fontName;
            row5_Pump_2_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_2_RunFeedback.Value2 = "Trạng thái bơm 2";
            row5_Pump_2_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Pump_2_FaultID = wsObject.get_Range("F5");
            row5_Pump_2_FaultID.Font.Size = fontSizeTenTruong;
            row5_Pump_2_FaultID.Font.Name = fontName;
            row5_Pump_2_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_2_FaultID.Value2 = "Mã lỗi bơm 2";
            row5_Pump_2_FaultID.ColumnWidth = 30;

            Excel.Range row5_Pump_3_RunFeedback = wsObject.get_Range("G5");
            row5_Pump_3_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Pump_3_RunFeedback.Font.Name = fontName;
            row5_Pump_3_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_3_RunFeedback.Value2 = "Trạng thái bơm 3";
            row5_Pump_3_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Pump_3_FaultID = wsObject.get_Range("H5");
            row5_Pump_3_FaultID.Font.Size = fontSizeTenTruong;
            row5_Pump_3_FaultID.Font.Name = fontName;
            row5_Pump_3_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_3_FaultID.Value2 = "Mã lỗi bơm 3";
            row5_Pump_3_FaultID.ColumnWidth = 30;

            Excel.Range row5_Pump_4_RunFeedback = wsObject.get_Range("I5");
            row5_Pump_4_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Pump_4_RunFeedback.Font.Name = fontName;
            row5_Pump_4_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_4_RunFeedback.Value2 = "Trạng thái bơm 4";
            row5_Pump_4_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Pump_4_FaultID = wsObject.get_Range("J5");
            row5_Pump_4_FaultID.Font.Size = fontSizeTenTruong;
            row5_Pump_4_FaultID.Font.Name = fontName;
            row5_Pump_4_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Pump_4_FaultID.Value2 = "Mã lỗi bơm 4";
            row5_Pump_4_FaultID.ColumnWidth = 30;

            Excel.Range row5_Raker_1_RunFeedback = wsObject.get_Range("K5");
            row5_Raker_1_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Raker_1_RunFeedback.Font.Name = fontName;
            row5_Raker_1_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_1_RunFeedback.Value2 = "Trạng thái cào rác 1";
            row5_Raker_1_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Raker_1_FaultID = wsObject.get_Range("L5");
                row5_Raker_1_FaultID.Font.Size = fontSizeTenTruong;
                row5_Raker_1_FaultID.Font.Name = fontName;
                row5_Raker_1_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row5_Raker_1_FaultID.Value2 = "Mã lỗi cào rác 1";
                row5_Raker_1_FaultID.ColumnWidth = 30;

            Excel.Range row5_Raker_2_RunFeedback = wsObject.get_Range("M5");
            row5_Raker_2_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Raker_2_RunFeedback.Font.Name = fontName;
            row5_Raker_2_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_2_RunFeedback.Value2 = "Trạng thái cào rác 2";
            row5_Raker_2_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Raker_2_FaultID = wsObject.get_Range("N5");
                row5_Raker_2_FaultID.Font.Size = fontSizeTenTruong;
                row5_Raker_2_FaultID.Font.Name = fontName;
                row5_Raker_2_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row5_Raker_2_FaultID.Value2 = "Mã lỗi cào rác 2";
                row5_Raker_2_FaultID.ColumnWidth = 30;

            Excel.Range row5_Raker_3_RunFeedback = wsObject.get_Range("O5");
            row5_Raker_3_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Raker_3_RunFeedback.Font.Name = fontName;
            row5_Raker_3_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_3_RunFeedback.Value2 = "Trạng thái cào rác 3";
            row5_Raker_3_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Raker_3_FaultID = wsObject.get_Range("P5");
            row5_Raker_3_FaultID.Font.Size = fontSizeTenTruong;
            row5_Raker_3_FaultID.Font.Name = fontName;
            row5_Raker_3_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_3_FaultID.Value2 = "Mã lỗi cào rác 3";
            row5_Raker_3_FaultID.ColumnWidth = 30;

            Excel.Range row5_Raker_4_RunFeedback = wsObject.get_Range("Q5");
            row5_Raker_4_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Raker_4_RunFeedback.Font.Name = fontName;
            row5_Raker_4_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_4_RunFeedback.Value2 = "Trạng thái cào rác 4";
            row5_Raker_4_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Raker_4_FaultID = wsObject.get_Range("R5");
            row5_Raker_4_FaultID.Font.Size = fontSizeTenTruong;
            row5_Raker_4_FaultID.Font.Name = fontName;
            row5_Raker_4_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Raker_4_FaultID.Value2 = "Mã lỗi cào rác 4";
            row5_Raker_4_FaultID.ColumnWidth = 30;

            Excel.Range row5_Conveyer_RunFeedback = wsObject.get_Range("S5");
            row5_Conveyer_RunFeedback.Font.Size = fontSizeTenTruong;
            row5_Conveyer_RunFeedback.Font.Name = fontName;
            row5_Conveyer_RunFeedback.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Conveyer_RunFeedback.Value2 = "Trạng thái băng tải";
            row5_Conveyer_RunFeedback.ColumnWidth = 30;

            Excel.Range row5_Conveyer_FaultID = wsObject.get_Range("T5");
            row5_Conveyer_FaultID.Font.Size = fontSizeTenTruong;
            row5_Conveyer_FaultID.Font.Name = fontName;
            row5_Conveyer_FaultID.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            row5_Conveyer_FaultID.Value2 = "Mã lỗi băng tải";
            row5_Conveyer_FaultID.ColumnWidth = 30;

            Excel.Range row5_Object = wsObject.get_Range("A5", "T5");
            row5_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#A6A6A6"));

            row_Object = 5;
            ExportToExcelDataContext context = new ExportToExcelDataContext();
            foreach (DAILY SP in context.DAILies)
            {
                row_Object++;
                dynamic[] arr_Object = { SP.ID, SP.TIME,
                                             SP.PUMP_1_RUNFEEDBACK, SP.PUMP_1_FAULTID,
                                             SP.PUMP_2_RUNFEEDBACK, SP.PUMP_2_FAULTID,
                                             SP.PUMP_3_RUNFEEDBACK, SP.PUMP_3_FAULTID,
                                             SP.PUMP_4_RUNFEEDBACK, SP.PUMP_4_FAULTID,
                                             SP.RAKER_1_RUNFEEDBACK, SP.RAKER_1_FAULTID,
                                             SP.RAKER_2_RUNFEEDBACK, SP.RAKER_2_FAULTID,
                                             SP.RAKER_3_RUNFEEDBACK, SP.RAKER_3_FAULTID,
                                             SP.RAKER_4_RUNFEEDBACK, SP.RAKER_4_FAULTID,
                                             SP.CONVEYER_RUNFEEDBACK, SP.CONVEYER_FAULTID};
                Excel.Range rowData_Object = wsObject.get_Range("A" + row_Object, "T" + row_Object);//Lấy dòng thứ row ra để đổ dữ liệu
                rowData_Object.Font.Size = fontSizeNoiDung;
                rowData_Object.Font.Name = fontName;
                rowData_Object.Value2 = arr_Object;
                rowData_Object.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                if ((row_Object % 2) == 0)
                {
                    rowData_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#D9D9D9"));
                }
                else
                {
                    rowData_Object.Interior.Color = ColorTranslator.ToOle(System.Drawing.ColorTranslator.FromHtml("#A6A6A6"));
                }
            }

            BorderAround(wsObject.get_Range("A5", "T" + row_Object));
            #endregion


            wb.SaveAs(curfile);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static void BorderAround(Excel.Range range)
        {
            Excel.Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.White;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
    }
}
