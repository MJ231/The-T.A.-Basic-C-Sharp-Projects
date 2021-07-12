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
            Console.WriteLine("Please Enter the Current Day of the Week."); // User input
            var entry = Console.ReadLine(); // Variable entry

            Start:
            try // Try program to see if it works
            {
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);
            }
            catch (System.ArgumentException) // Catch statement
            {
                Console.WriteLine("Please Enter an Actual Day of the Week."); // Error message to wrong entry
                entry = Console.ReadLine();
                goto Start;
            }
            DaysOfTheWeek value = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), entry);

            Console.WriteLine(value); // Vaule of variables
            Console.ReadLine(); // End program
        }
        public enum DaysOfTheWeek // Enum values for program
        {
            Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 // Days of the week as integers and variables
        }
    }
}
