using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number Please."); // User input
            string numOne = Console.ReadLine();
            int numTwo = Int32.Parse(numOne);
            Console.WriteLine("Pick a Second Number if You Dare. Otherwise, just Hit Return."); // User input
            string numThree = Console.ReadLine(); // Add string

            OptionalParameters parameter = new OptionalParameters(); // Integrate other class
            parameter.Total(numTwo, numThree);

            Console.WriteLine("The total equals:" + parameter.Total(numTwo, numThree)); //Get results

            Console.ReadLine(); // End program
        }
    }
}
