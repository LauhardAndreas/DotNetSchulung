using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var logger = new LoggingService();
                var date = DateTime.Now.ToString();
                logger.logIt("test-"+date);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine($"Kein logging möglich!\n{e.Message}");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
