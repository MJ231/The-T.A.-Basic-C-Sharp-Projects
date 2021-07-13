using System;
using System.Collections.Generic;
using System.Text;


namespace Class_Assignment
{
    public class ClassMath // Name class
    {
        public static void NumberMethod(out int resultOne, int numberOne) // Void method
        {
            resultOne = numberOne / 2; // Equation of first integer
        }
        public static void NumberMethod(out int resultOne, int numberOne, int numberTwo = 0) // More methods
        {
            resultOne = (numberOne / 2) * numberTwo; // Equation of second integer
        }
    }
}
