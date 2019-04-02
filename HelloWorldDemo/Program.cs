using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //docs.microsoft.com


            //ShortKeys
            //WL -> WriteLine
            //Strg K+ S steht für Surround 

            //Vererbung Fehlerhandling
            //Exceptionclasse ist die Basisklasse 
            //Alle anderen Fehlerklassen erben von Exception
            //seit C#7 kann man in try catch logik packen
            try
            {
                Console.WriteLine($"Hello World from {args[0]}");
                Console.WriteLine("Do something after error");

            }
            catch (IndexOutOfRangeException ioure) when (ioure.Message.Contains("index"))
            {

                Console.WriteLine(ioure.Message);
            }
            catch (Exception e)
            {
               var exp = new DemoException(e.Message);
            }
        }
    }

    // internal ist das default verhalten bei klassen
    public class DemoException : Exception
    {
        // überladener constructor
        public DemoException(string message)
        {

        }
         //basis Construktor 
         //Compiler verlangt einen Construktor
        public DemoException()
        {

        }
    }
}
