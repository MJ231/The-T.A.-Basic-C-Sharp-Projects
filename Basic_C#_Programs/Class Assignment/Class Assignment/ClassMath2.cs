using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public static class ClassMath2 //Class name
    {
        public static int numberOne (int numOne, int numTwo) //Static class
        {
            int result = numOne / 2; //Results to operation  
            int resultTwo = numTwo / 2;
            Console.WriteLine("Your Number Divided by 2 = " + resultTwo);
            return resultTwo;
        }
    }
}
