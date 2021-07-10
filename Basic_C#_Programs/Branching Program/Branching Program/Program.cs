using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // Print sentence
            Console.WriteLine("Please enter the package weight:"); // Entered the shipping weight, if heavier than 50 it is no good
            int weiNum = Convert.ToInt32(Console.ReadLine());
            string result = weiNum > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Package is not too heavy to ship via Package Express.";
            Console.WriteLine(result);
            Console.WriteLine("Please enter the package width:"); // Entered the shipping width, if bigger than 50 it is no good
            int widNum = Convert.ToInt32(Console.ReadLine());
            string comparisonResult = widNum > 50 ? "Package too big to be shipped via Package Express." : "Package not too big to be shipped via Package Express.";
            Console.WriteLine(comparisonResult);
            Console.WriteLine("Please enter the package height:"); // Entered the shipping height, if bigger than 50 it is no good 
            int heiNum = Convert.ToInt32(Console.ReadLine());
            string anotherResult = heiNum > 50 ? "Package too big to be shipped via Package Express." : "Package not too big to be shipped via Package Express";
            Console.WriteLine(anotherResult);
            Console.WriteLine("Please enter the package length:"); // Entered the shipping length, if bigger than 50 it is no good
            int lenNum = Convert.ToInt32(Console.ReadLine());
            string continueResult = lenNum > 50 ? "Package too big to be shipped via Package Express." : "Package not too big to be shipped via Package Express.";
            Console.WriteLine(continueResult);
            Console.WriteLine("Your estimated total for shipping this package is: $800.8"); // Took the total dimensions of all three numbers (16, 13, 11) and multiplied all together times the weight number (35)
            Console.WriteLine("Thank You!");                                                // then divided by 100 and got the total dollar amount of $800.8
            Console.ReadLine();
            // End Program
        }
    }
}
