using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Start application
            Console.WriteLine("These are the Functions of the Program.");
            int number = 45;
            string stNum = "500";

            Console.WriteLine("45 plus 100 equals: "); // Addition function initiated into whole number
            FunctionsMath add = new FunctionsMath(); // Class program integrated
            add.Adding(number);
            Console.ReadLine();

            Console.WriteLine("45 divided by 2 equals: "); // Division function initiated into decimal 
            FunctionsMath divi = new FunctionsMath(); // Class program integrated
            divi.Divide(number);
            Console.ReadLine();

            Console.WriteLine("45 multiplied by 500 equals: "); // Multiplication function initiated into whole number
            FunctionsMath thNum = new FunctionsMath(); // Class program integrated
            thNum.Third(stNum);
            Console.WriteLine("Thank you!");
            Console.ReadLine(); // End program
        }
    }
}
