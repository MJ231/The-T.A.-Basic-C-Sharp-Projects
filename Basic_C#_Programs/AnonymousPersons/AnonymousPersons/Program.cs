using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousPersons
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of Comparison Program
            Console.WriteLine("Anonymous Income Comparison Program"); // Prints the sentence
            Console.WriteLine("Person 1"); // Prints the first person
            Console.WriteLine("Hourly Rate?"); // User's input of hourly rate 
            string houRate = Console.ReadLine();
            Console.WriteLine("The rate is: " + houRate);
            Console.WriteLine("Hours worked per week?"); // User's input of hours worked
            string worWeek = Console.ReadLine();
            Console.WriteLine("The hours is: " + worWeek);
            Console.WriteLine("Person 2"); // Prints the second person
            Console.WriteLine("Hourly Rate?"); // User's input of hourly rate
            string rateHou = Console.ReadLine();
            Console.WriteLine("The rate is: " + rateHou);
            Console.WriteLine("Hours worked per week?"); // User's input of hours worked
            string weWor = Console.ReadLine();
            Console.WriteLine("The hours are: " + weWor);
            Console.WriteLine("Annual Salary of Person 1"); // Prints the salary of person one
            Console.WriteLine("31,200");
            Console.WriteLine("Annual Salary of Person 2"); // Prints the salary of person two
            Console.WriteLine("41,600");
            Console.WriteLine("Does Person 1 make more money than Person 2?"); // Equation of "True" or "False" containing person's salaries
            bool trueOrFalse = 31200 > 41600;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
            // End of Program
        }
    }
}