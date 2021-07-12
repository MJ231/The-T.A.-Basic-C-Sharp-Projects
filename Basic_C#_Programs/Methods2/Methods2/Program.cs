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
            Console.WriteLine("Pick a Number."); // User input
            string add1 = Console.ReadLine();
            int addition1 = Int32.Parse(add1);

            Console.WriteLine("Pick a Second Number."); // User input
            string add2 = Console.ReadLine();
            int addition2 = Int32.Parse(add2);

            Parameters paraMeters = new Parameters(); //Name parameters
            
            paraMeters.Total(addition1, addition2);
            Console.ReadLine(); //End program
        }
    }
}