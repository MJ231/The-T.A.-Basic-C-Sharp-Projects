using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of Application
            Console.WriteLine("What is your age?"); // Answer to age limit
            int age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Have you ever had a DUI? Yes or No?"); // Answer to having any DUI's
            string dui = Console.ReadLine();
            
            Console.WriteLine("How many speeding tickets do you have?"); // Answer to having any speeding tickets
            int speTick = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Qualified?"); // Answer to being qualified
            bool qualify = (age >= 15 && (dui == "no" || dui == "No") && speTick <= 3);
            Console.WriteLine(qualify);
            Console.ReadLine();
            // End of application

        }
    }
}
