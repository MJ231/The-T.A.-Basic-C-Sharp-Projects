using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods2
{
    public class Parameters // Name class
    {
        public void Nums(int num1, int num2) // Creates void method using two parameters
        {
            Console.WriteLine("Pick a Number:"); // User input
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int result1 = userNum1 * 2; // Assigns a math operation on the first integer
            Console.WriteLine("Pick Another Number:"); // User input
            int userNum2 = Convert.ToInt32(Console.ReadLine()); // Displays second integer to screen

            Console.WriteLine(userNum1 + " X 2 equals: " + result1); // Results of the first integer

            Console.ReadLine(); // End program

        }
    }
}