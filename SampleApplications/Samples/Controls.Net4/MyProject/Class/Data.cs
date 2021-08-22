using System;
using System.Threading;

namespace Opc.Ua.Sample.Controls
{
    public class Data
    {
        public bool Pump_1_RunFeedback;
        public short Pump_1_FaultID;
        public bool Pump_2_RunFeedback;
        public short Pump_2_FaultID;
        public bool Pump_3_RunFeedback;
        public short Pump_3_FaultID;
        public bool Pump_4_RunFeedback;
        public short Pump_4_FaultID;
        public bool Raker_1_RunFeedback;
        public short Raker_1_FaultID;
        public bool Raker_2_RunFeedback;
        public short Raker_2_FaultID;
        public bool Raker_3_RunFeedback;
        public short Raker_3_FaultID;
        public bool Raker_4_RunFeedback;
        public short Raker_4_FaultID;
        public bool Conveyer_RunFeedback;
        public short Conveyer_FaultID;
        public short GlobalMode;
        public float Temperature;
        public float Humidity;
        public float LevelInSuctionTank_Filtered;
        public bool EmptySuctionTank;
        public float Above_Level;
        public float Bottom_Level;
        public int TimeLimit;
        public int MasterChangeFrequency;
        public int RakerRunDelay;
        public int PumpRunDelay;
        public int ConveyerStopDelay;
        public int RakerStopDelay;
        //Public class
        protected Data()
        {

        }

        private static Data _instance;
        public static Data Instance()
        {
            if (_instance == null)
            {
                _instance = new Data();
            }
            return _instance;
        }

        public int Period = 2000;
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

        void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var nodeid = "";
                var value = "";

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_1_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_1_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_1_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_1_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_2_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_2_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_2_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_2_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_3_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_3_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_3_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_3_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_4_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_4_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Pump_4_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Pump_4_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_1_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_1_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_1_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_1_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_2_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_2_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_2_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_2_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_3_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_3_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_3_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_3_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_4_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_4_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Raker_4_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Raker_4_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_RunFeedback";
                value = PLC.Instance().VariableRead(nodeid);
                Conveyer_RunFeedback = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,Conveyer_FaultID";
                value = PLC.Instance().VariableRead(nodeid);
                Conveyer_FaultID = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_GlobalMode"; ;
                value = PLC.Instance().VariableRead(nodeid);
                GlobalMode = Convert.ToInt16(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Temperature"; ;
                value = PLC.Instance().VariableRead(nodeid);
                Temperature = Convert.ToSingle(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Humidity"; ;
                value = PLC.Instance().VariableRead(nodeid);
                Humidity = Convert.ToSingle(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_LevelInSuctionTank_Filtered";
                value = PLC.Instance().VariableRead(nodeid);
                LevelInSuctionTank_Filtered = Convert.ToSingle(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_EmptySuctionTank";
                value = PLC.Instance().VariableRead(nodeid);
                EmptySuctionTank = Convert.ToBoolean(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Above_Level";
                value = PLC.Instance().VariableRead(nodeid);
                Above_Level = Convert.ToSingle(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_Bottom_Level";
                value = PLC.Instance().VariableRead(nodeid);
                Bottom_Level = Convert.ToSingle(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_TimeLimit"; ;
                value = PLC.Instance().VariableRead(nodeid);
                TimeLimit = Convert.ToInt32(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_MasterChangeFrequency"; ;
                value = PLC.Instance().VariableRead(nodeid);
                MasterChangeFrequency = Convert.ToInt32(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerRunDelay"; ;
                value = PLC.Instance().VariableRead(nodeid);
                RakerRunDelay = Convert.ToInt32(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_PumpRunDelay"; ;
                value = PLC.Instance().VariableRead(nodeid);
                PumpRunDelay = Convert.ToInt32(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_ConveyerStopDelay"; ;
                value = PLC.Instance().VariableRead(nodeid);
                ConveyerStopDelay = Convert.ToInt32(value);

                nodeid = "ns=2;s=TCS:[SeniorStudentHD.Station 1.101]DP,General_RakerStopDelay"; ;
                value = PLC.Instance().VariableRead(nodeid);
                RakerStopDelay = Convert.ToInt32(value);
            }
            catch
            {
                ;
            }
        }
    }
}
