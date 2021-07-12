using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMethods
{
    public class FunctionsMath // Class name
    {
        public void Adding(int addNum) // Addition method
        {
            Console.WriteLine(addNum + 100);

        }

        public void Divide(decimal divNum) // Decimal method
        {
            Console.WriteLine(divNum / 2);

        }

        public void Third(string thirdNum) // String method
        {
            int tNum = Convert.ToInt32(thirdNum);
            int tNumTotal = tNum * 45;
            Console.WriteLine(tNumTotal);
        }
    }
}
