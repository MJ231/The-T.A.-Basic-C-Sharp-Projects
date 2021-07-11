using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parameters paraMeters = new Parameters(); //Name parameters
            int parameter1 = 20;
            int parameter2 = 40;
            paraMeters.voidMethod(parameter1, parameter2);
            Console.ReadLine(); //End program
        }
    }
}