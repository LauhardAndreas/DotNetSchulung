using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieDemo
{
    public class ShowPolymorphie
    {
        public int Sum(int a, int b)
        {
            return (a + b);
        }
        // Methoden Signatur
        //rückgabetyp name property typen
        //int Sum(double a, double b)
        public int Sum(double a, double b, double c = 0)
        {
            return (int)(a + b + c);
        }
    }
}
