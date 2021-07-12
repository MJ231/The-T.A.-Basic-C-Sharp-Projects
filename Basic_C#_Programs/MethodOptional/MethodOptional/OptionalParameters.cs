using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    class OptionalParameters // Class name
    {
        public int Total(int numOne, string numTwo) // Method initiated
        {
            int combo; // Give integers an operation
            if (numTwo == "")
            {
                combo = numOne;
            }
            else
            {
                int numThree = Convert.ToInt32(numTwo);
                combo = numOne + numThree;
            }
            return combo; // Returns results 
        }
    }
}
