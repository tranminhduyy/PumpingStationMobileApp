using System;

namespace Opc.Ua.Sample.Controls
{
    static class Program
    {
        public static Page_Pump Pump_1 = new Page_Pump();
        public static Page_Pump Pump_2 = new Page_Pump();
        public static Page_Pump Pump_3 = new Page_Pump();
        public static Page_Pump Pump_4 = new Page_Pump();
        public static Page_Raker Raker_1 = new Page_Raker();
        public static Page_Raker Raker_2 = new Page_Raker();
        public static Page_Raker Raker_3 = new Page_Raker();
        public static Page_Raker Raker_4 = new Page_Raker();
        public static Page_Conveyer Conveyer = new Page_Conveyer();
        public static Page_General General = new Page_General();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
        }
    }
}
