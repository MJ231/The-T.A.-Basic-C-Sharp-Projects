using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, Welcome to the Beginning of the Program:"); // Prints what's in parentheses to screen


            Parameters parameter = new Parameters();  // Instantiates Parameters class


            parameter.Nums(num1: 12, num2: 10); // Calls the method in the class specifying the parameters by name
            Console.ReadLine(); // End program
        }
    }
}