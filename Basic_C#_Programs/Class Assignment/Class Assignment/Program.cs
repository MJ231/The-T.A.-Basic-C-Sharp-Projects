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
            
            Console.WriteLine("Pick a Number of Your Choice."); //User input
            int numTwo = Convert.ToInt32(Console.ReadLine()); //Convert integer
            int numOne = 10; //Give integers
            int car = 90;
            int truck = 3;


            ClassMath FirstOp = new ClassMath(); //Class method
            FirstOp.MathMethod(numOne, numTwo);
            FirstOp.MathMethod2(car, truck);

            Console.ReadLine(); //End program
        }
    }
}
