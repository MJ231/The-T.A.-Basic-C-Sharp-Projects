using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Parameters //Name class
    {
        public void Total(int parameter1, int parameter2) //Void of two parameters
        {
            int addNum1 = parameter1; // Parameter equation
            int addNum2 = parameter2;
            int total = addNum1 + addNum2;
            Console.WriteLine("Your number " + addNum1 + " plus your number " + addNum2 + " equals: " + total); //Initiate results
        }
    }
}
