using System;
using System.Data.SqlClient;
using System.Data;

namespace Opc.Ua.Sample.Controls
{
    public class SQL
    {
        public DataTable dt_Data = new DataTable();
        public DataTable dt_ChartLevel = new DataTable();
        public DataTable dt_ChartTemperature = new DataTable();
        public DataTable dt_ChartHumidity = new DataTable();

        SqlConnection con = new SqlConnection(Properties.Settings.Default.SQL);
        public bool SQL_Connected = false;

        protected SQL()
        {

        }

        private static SQL _instance;
        public static SQL Instance()
        {
            if (_instance == null)
            {
                _instance = new SQL();
            }
            return _instance;
        }

        public void TestConnection()
        {
            try
            {
                con.Open();
                SQL_Connected = true;
                con.Close();
            }
            catch
            {
                SQL_Connected = false;
            }
        }

        public void Insert_Data()
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "INSERT INTO TABLE_SCADA(DATE,TIME,PUMP_1_RUNFEEDBACK,PUMP_1_FAULTID,PUMP_2_RUNFEEDBACK,PUMP_2_FAULTID,PUMP_3_RUNFEEDBACK,PUMP_3_FAULTID,PUMP_4_RUNFEEDBACK,PUMP_4_FAULTID,RAKER_1_RUNFEEDBACK,RAKER_1_FAULTID,RAKER_2_RUNFEEDBACK,RAKER_2_FAULTID,RAKER_3_RUNFEEDBACK,RAKER_3_FAULTID,RAKER_4_RUNFEEDBACK,RAKER_4_FAULTID,CONVEYER_RUNFEEDBACK,CONVEYER_FAULTID,GLOBALMODE,TEMPERATURE,HUMIDITY,LEVELINSUCTIONTANK_FILTERED,EMPTYSUCTIONTANK,ABOVE_LEVEL,BOTTOM_LEVEL,TIMELIMIT,MASTERCHANGEFREQUENCY,RAKERRUNDELAY,PUMPRUNDELAY,CONVEYERSTOPDELAY,RAKERSTOPDELAY)" +
                                            "VALUES(@DATE,@TIME,@PUMP_1_RUNFEEDBACK,@PUMP_1_FAULTID,@PUMP_2_RUNFEEDBACK,@PUMP_2_FAULTID,@PUMP_3_RUNFEEDBACK,@PUMP_3_FAULTID,@PUMP_4_RUNFEEDBACK,@PUMP_4_FAULTID,@RAKER_1_RUNFEEDBACK,@RAKER_1_FAULTID,@RAKER_2_RUNFEEDBACK,@RAKER_2_FAULTID,@RAKER_3_RUNFEEDBACK,@RAKER_3_FAULTID,@RAKER_4_RUNFEEDBACK,@RAKER_4_FAULTID,@CONVEYER_RUNFEEDBACK,@CONVEYER_FAULTID,@GLOBALMODE,@TEMPERATURE,@HUMIDITY,@LEVELINSUCTIONTANK_FILTERED,@EMPTYSUCTIONTANK,@ABOVE_LEVEL,@BOTTOM_LEVEL,@TIMELIMIT,@MASTERCHANGEFREQUENCY,@RAKERRUNDELAY,@PUMPRUNDELAY,@CONVEYERSTOPDELAY,@RAKERSTOPDELAY)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("DATE", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("TIME", DateTime.Now.ToString("HH: mm:ss"));
                    cmd.Parameters.AddWithValue("PUMP_1_RUNFEEDBACK", Data.Instance().Pump_1_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("PUMP_1_FAULTID", Data.Instance().Pump_1_FaultID);
                    cmd.Parameters.AddWithValue("PUMP_2_RUNFEEDBACK", Data.Instance().Pump_2_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("PUMP_2_FAULTID", Data.Instance().Pump_2_FaultID);
                    cmd.Parameters.AddWithValue("PUMP_3_RUNFEEDBACK", Data.Instance().Pump_3_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("PUMP_3_FAULTID", Data.Instance().Pump_3_FaultID);
                    cmd.Parameters.AddWithValue("PUMP_4_RUNFEEDBACK", Data.Instance().Pump_4_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("PUMP_4_FAULTID", Data.Instance().Pump_4_FaultID);
                    cmd.Parameters.AddWithValue("RAKER_1_RUNFEEDBACK", Data.Instance().Raker_1_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("RAKER_1_FAULTID", Data.Instance().Raker_1_FaultID);
                    cmd.Parameters.AddWithValue("RAKER_2_RUNFEEDBACK", Data.Instance().Raker_2_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("RAKER_2_FAULTID", Data.Instance().Raker_2_FaultID);
                    cmd.Parameters.AddWithValue("RAKER_3_RUNFEEDBACK", Data.Instance().Raker_3_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("RAKER_3_FAULTID", Data.Instance().Raker_3_FaultID);
                    cmd.Parameters.AddWithValue("RAKER_4_RUNFEEDBACK", Data.Instance().Raker_4_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("RAKER_4_FAULTID", Data.Instance().Raker_4_FaultID);
                    cmd.Parameters.AddWithValue("CONVEYER_RUNFEEDBACK", Data.Instance().Conveyer_RunFeedback.ToString());
                    cmd.Parameters.AddWithValue("CONVEYER_FAULTID", Data.Instance().Conveyer_FaultID);
                    cmd.Parameters.AddWithValue("GLOBALMODE", Data.Instance().GlobalMode);
                    cmd.Parameters.AddWithValue("TEMPERATURE", Data.Instance().Temperature);
                    cmd.Parameters.AddWithValue("HUMIDITY", Data.Instance().Humidity);
                    cmd.Parameters.AddWithValue("LEVELINSUCTIONTANK_FILTERED", Data.Instance().LevelInSuctionTank_Filtered);
                    cmd.Parameters.AddWithValue("EMPTYSUCTIONTANK", Data.Instance().EmptySuctionTank.ToString());
                    cmd.Parameters.AddWithValue("ABOVE_LEVEL", Data.Instance().Above_Level);
                    cmd.Parameters.AddWithValue("BOTTOM_LEVEL", Data.Instance().Bottom_Level);
                    cmd.Parameters.AddWithValue("TIMELIMIT", Data.Instance().TimeLimit);
                    cmd.Parameters.AddWithValue("MASTERCHANGEFREQUENCY", Data.Instance().MasterChangeFrequency);
                    cmd.Parameters.AddWithValue("RAKERRUNDELAY", Data.Instance().RakerRunDelay);
                    cmd.Parameters.AddWithValue("PUMPRUNDELAY", Data.Instance().PumpRunDelay);
                    cmd.Parameters.AddWithValue("CONVEYERSTOPDELAY", Data.Instance().ConveyerStopDelay);
                    cmd.Parameters.AddWithValue("RAKERSTOPDELAY", Data.Instance().RakerStopDelay);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
            }
        }

        public void Query_Data(DateTime Start, DateTime End)
        {
            if(SQL_Connected)
            {
                con.Open();
                string sql = "SELECT * FROM TABLE_SCADA WHERE CONVERT (DATE, DATE) BETWEEN @START AND @END";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("START", Start);
                    cmd.Parameters.AddWithValue("END", End);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt_Data.Clear();
                    da.Fill(dt_Data);
                }
                con.Close();
            }
        }

        public void Query_ChartLevel(DateTime Start, DateTime End)
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "SELECT TIME,LEVELINSUCTIONTANK_FILTERED FROM TABLE_SCADA WHERE CONVERT (DATE, DATE) BETWEEN @START AND @END";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("START", Start);
                    cmd.Parameters.AddWithValue("END", End);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt_ChartLevel.Clear();
                    da.Fill(dt_ChartLevel);
                }
                con.Close();
            }
        }

        public void Query_ChartTemperature(DateTime Start, DateTime End)
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "SELECT TIME,TEMPERATURE FROM TABLE_SCADA WHERE CONVERT (DATE, DATE) BETWEEN @START AND @END";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("START", Start);
                    cmd.Parameters.AddWithValue("END", End);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt_ChartTemperature.Clear();
                    da.Fill(dt_ChartTemperature);
                }
                con.Close();
            }
        }

        public void Query_ChartHumidity(DateTime Start, DateTime End)
        {
            if (SQL_Connected)
            {
                con.Open();
                string sql = "SELECT TIME,HUMIDITY FROM TABLE_SCADA WHERE CONVERT (DATE, DATE) BETWEEN @START AND @END";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("START", Start);
                    cmd.Parameters.AddWithValue("END", End);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt_ChartHumidity.Clear();
                    da.Fill(dt_ChartHumidity);
                }
                con.Close();
            }
        }
    }
}
