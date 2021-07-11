using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter a Value to be Operated on.");
            int entry = Convert.ToInt32(Console.ReadLine());

            FunctionsMath result = new FunctionsMath();
            result.integerMod(entry);
            Console.WriteLine("The Result is: " + result.x);
            Console.ReadLine();

            decimal entryTwo = Convert.ToDecimal(entry);
            result.integerMod(entryTwo);
            Console.WriteLine("The Result is: " + result.y);
            Console.ReadLine();

            string entryThree = Convert.ToString(entry);
            result.integerMod(entryThree);
            Console.WriteLine("The result is: " + result.w);
            Console.ReadLine();
        }
    }
}
