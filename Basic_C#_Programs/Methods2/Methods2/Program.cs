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
            Console.WriteLine("Please Enter an Integer Value:"); // User input
            int one = Convert.ToInt32(Console.ReadLine()); // Convert integers to whole numbers
            Console.WriteLine("Please Enter a Second Integer Value:"); // User input
            int two = Convert.ToInt32(Console.ReadLine()); // Convert integers to whole numbers

            Parameters result = new Parameters(); // Integrate class program
            result.integerModifier(one, two); // Results displayed on console application
            result.integerModifier(5, 7); // Results displayed on console application
            Console.ReadLine(); // End program
        }
    }
}