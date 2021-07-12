using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Number of Your Choice that Will be Divided by 2:"); // User input
            int entry = Convert.ToInt32(Console.ReadLine()); // Convert to whole numbers
            int answer = 0;

            ClassMath adjusted = new ClassMath(); // Integrated from class 
            adjusted.Division(entry, out answer); // Adjusted entry from user input
            Console.WriteLine("Your Entered Value Divided by 2 is: " + answer); // Display results

            Console.WriteLine("Pick a Number of Your Choice that Will be Divided by 2:"); // User input
            decimal entry2 = Convert.ToInt32(Console.ReadLine()); // Convert to whole numbers
            decimal answer2 = 0;

            ClassMath.Division(entry2, out answer2); // Integrate from class program 
            Console.WriteLine(answer2); // Display results
            Console.ReadLine(); //End program
        }
    }
}
