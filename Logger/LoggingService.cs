using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Threading.Tasks;

namespace Logger
{
    public class LoggingService
    {
        private int logCount = 0;
        string filePath = "";
        public List<KeyValuePair<int, string>> list = null;

        public LoggingService()
        {
            list = new List<KeyValuePair<int, string>>();
            var path = (string)Environment.GetEnvironmentVariables()["APPDATA"];

            var dirName = "MySageLogs";
            var folderPath = Path.Combine(path, dirName);
            Directory.CreateDirectory(folderPath);

            var fileName = "log.txt";
            filePath = Path.Combine(folderPath, fileName);
        }

        /// <summary>
        /// Es soll eine Messages in de Datei log.txt geschrieben werden
        /// </summary>
        /// <param name="message"></param>
        public void Push()
        {
            foreach (var log in list)
            {
                using (var sw = new StreamWriter(filePath, append: true))  //named Parameter
                {
                    string key = log.Key < 10 ? "0" + log.Key.ToString() : log.Key.ToString();
                    sw.WriteLine($"{log.Key}:{log.Value}");
                }
            }
            ClearLog();
        }
     
        public void LogLine(string message)
        {
           var timeStamp = DateTime.Now;
           message = message + ":" + timeStamp;
           list.Add(new KeyValuePair<int, string>(logCount, message));
           logCount++;
        }

        public void Delete_Log_At_Line(int logLine)
        {
            if(logLine < list.Count() && logLine >= 0)
            {
                list.RemoveAt(logLine);
                logCount--;
            }
        }

        public void ClearLog()
        {
            list.Clear();
            logCount = 0;
        }

        public void Delete_LogFile()
        {
            if (File.Exists(filePath))
                File.Delete(filePath);

            ClearLog();
        }
    }
   
}
