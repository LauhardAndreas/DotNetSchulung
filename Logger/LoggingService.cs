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
        public LoggingService()
        {

        }

        /// <summary>
        /// Es soll eine Messages in de Datei log.txt geschrieben werden
        /// </summary>
        /// <param name="message"></param>
        public void logIt(string message)
        {
            var path = (string)Environment.GetEnvironmentVariables()["APPDATA"];

            var dirName = "MySageLogs";
            var folderPath = Path.Combine(path, dirName);
            Directory.CreateDirectory(folderPath);
           
            var fileName = "log.txt";
            var filePath = Path.Combine(folderPath, fileName);
            using (var sw = new StreamWriter(filePath, append: true))  //named Parameter
            {
                sw.WriteLine(message);
            }
        }
    }
}
