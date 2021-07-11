using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class ClassMath //Name class
    {
        public void MathMethod(int numOne, int numTwo) //Void method
        {
            int result = numOne / 2; //Results of operation 
            int resultTwo = numTwo / 2;
            Console.WriteLine("Your Number Divided by 2 = " + resultTwo);
        }
        public void MathMethod2(int numThree, int numFour) //More methods
        {
            int resultFive = numThree * numFour;
            Console.WriteLine(numThree + " x " + numFour + " = " + resultFive);
        }
        public static int MathMethod2(int numOne, out int numTwo) //Output method
        {
            numTwo = numOne + 5;
            return numTwo;
        }
    }
}
