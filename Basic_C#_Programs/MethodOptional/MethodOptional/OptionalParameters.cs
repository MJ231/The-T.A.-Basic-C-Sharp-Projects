using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    public class OptionalParameters //Class name
    {
        public int MathMethod(int numOne, string ans) //Method initiated
        {
            int result = 0; //Give integers an operation
            if (ans == "")
            {
                result = numOne + 10;
            }
            else
            {
                int numTwo = Convert.ToInt32(ans);
                result = numOne + numTwo + 10;
            }
            return result; //Returns results 
        }
    }
}
