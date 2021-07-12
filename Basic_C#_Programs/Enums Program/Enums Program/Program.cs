using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try // Try program to see if it works
            {
                Console.WriteLine("Enter the Current Day of the Week."); // User input
                string userDay = Console.ReadLine();

                if (Enum.TryParse(userDay, out DaysOfTheWeek dayNum)) // If statement
                {
                    Console.WriteLine("Today is " + dayNum); // Ouput message
                }
            }
            catch (Exception ex) // Catch statement
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine(); // End program
        }
        public enum DaysOfTheWeek // Enum values for program
        {
            Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 // Days of the week as integers
        }
    }
}
