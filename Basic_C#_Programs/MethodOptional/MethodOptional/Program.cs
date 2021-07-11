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
            Console.WriteLine("Pick a Number Please."); //User input
            int numOne = Convert.ToInt32(Console.ReadLine()); //Convert integer to a whole number
            Console.WriteLine("Pick a Second Number if You Dare. Otherwise, just Hit Return."); //User input
            string ans = Console.ReadLine(); //Add string

            OptionalParameters FirOp = new OptionalParameters(); //Integrate other class

            Console.WriteLine("Your Input(s) + 10 = " + FirOp.MathMethod(numOne, ans)); //Get results

            Console.ReadLine(); //End program
        }
    }
}
