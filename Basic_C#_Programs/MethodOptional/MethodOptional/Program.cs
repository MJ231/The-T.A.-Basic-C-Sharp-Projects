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
            OptionalParameters result = new OptionalParameters(); // Integrate class program

            Console.WriteLine("Please Enter an Integer:"); // User input
            int firstEntry = Convert.ToInt32(Console.ReadLine()); // Convert integer to whole numbers

            Console.WriteLine("Please Optionally Enter a Second Integer: (Otherwise, Press Enter.)"); // Optional user input
            string input = Console.ReadLine();
            int secondEntry = 0;
            if (!string.IsNullOrEmpty(input)) // If statement
            {
                secondEntry = Convert.ToInt16(input); // Inputs second entry after user input
                result.optionalModifier(firstEntry, secondEntry);
                Console.WriteLine("The First Modified Entry is: " + result.x + " and the Second Modified Entry is: " + result.y); // Displays results to the user

            }
            else
            {
                result.optionalModifier(firstEntry); // Only displays the first entry
                Console.WriteLine("The First Modified Entry is: " + result.x); // Displays results to the user

            }

            Console.ReadLine(); // End program
        }
    }
}