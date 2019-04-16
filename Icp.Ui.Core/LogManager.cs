using System;
using System.Configuration;
using System.IO;

namespace Icp.Ui.Core
{
    public class LogManager
    {
        public static readonly string LogDirectory;

        static LogManager()
        {
            LogDirectory = ConfigurationManager.AppSettings["ErrorLogDirectory"];
        }

        /*LogManager.WriteErrorLog("Error", ex.ToString(), "MyGpDashboardController > GetCesChartData");*/
        public static string WriteErrorLog(string errorType, Exception exception, string methodName = "")
        {
            if (!Directory.Exists(LogDirectory))
            {
                Directory.CreateDirectory(LogDirectory);
            }

            string fileName = string.Format("{0}_{1}.txt", DateTime.Now.ToString("dd-MMM-yyyy"), errorType);
            string path = LogDirectory + "\\" + fileName;       
            using (StreamWriter sw = (File.Exists(path)) ? File.AppendText(path) : File.CreateText(path))
            {
                sw.WriteLine("{0} ::::  DateTime: {1} :::: Message: {2} :::: Method Name:  {3}", errorType, DateTime.Now.ToString(), exception.ToString(), methodName);
                sw.WriteLine("==============================================================================================================================");
            }

            return path;
        }
    }
}