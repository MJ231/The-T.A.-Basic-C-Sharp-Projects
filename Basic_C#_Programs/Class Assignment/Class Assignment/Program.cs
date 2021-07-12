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
            int divNum = Convert.ToInt32(Console.ReadLine());
            int div1;

            ClassMath divide = new ClassMath(); // Integrated from class 
            divide.NumDivi(divNum, out div1);

            Console.WriteLine("\n{0} divided by 2 equals: {1}", divNum, div1); // Results from method

            Console.ReadLine(); //End program
        }
    }
}
