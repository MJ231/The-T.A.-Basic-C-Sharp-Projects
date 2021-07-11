using CallMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Number and It'll Perform Three Math Functions:"); //User Input
            int numOne = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine(numOne + " + 100 = " + MathOperation.Add(numOne)); //Sum of two numbers
            Console.WriteLine(numOne + " x 40 = " + MathOperation.Mult(numOne)); //Multiplication of two numbers
            Console.WriteLine(numOne + " - 10 = " + MathOperation.Subtract(numOne)); //Subtraction of two numbers
            Console.WriteLine("You are Awesome!");
            Console.ReadLine(); //End program
            
        }
    }
}
