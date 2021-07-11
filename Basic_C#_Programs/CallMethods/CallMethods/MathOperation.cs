using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallMethods
{
    class MathOperation //Create class
    {
        public static int Add(int numOne)
        {
            return numOne + 100; //int Add1 = num1 + 100;
        }
        public static int Mult (int numOne)
        {
            return numOne * 40; //int Mult1 = num1 * 40;
        }
        public static int Subtract (int numOne)
        {
            return numOne - 10; //int Subtract1 = num1 - 10;
        }    
    }
}
