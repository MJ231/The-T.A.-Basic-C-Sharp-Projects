using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_and_Time_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now; // Create application
            Console.WriteLine("Today = " + DateTime.Now); // Shows the current date

            Console.WriteLine("Pick a Number:"); // User input
            int answer = Convert.ToInt32(Console.ReadLine()); // Convert to whole integers

            TimeSpan duration = new TimeSpan(0, answer, 0, 0); // Integrate future time
            DateTime futureTime = today.Add(duration);
            Console.WriteLine("In " + answer + " Hours, it Will be: " + futureTime); // Displays future time per user input
            Console.ReadLine(); // End program
        }
    }
}
