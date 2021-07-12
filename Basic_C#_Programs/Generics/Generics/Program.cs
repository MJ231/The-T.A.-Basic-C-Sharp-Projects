using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> empList = new Employee<string>(); // Integrate employee class
            Employee<int> empInt = new Employee<int>();
            empList.things = new List<string>(); // Create loop to show on console application 
            empList.things.Add("Albert");
            empList.things.Add("Lopez");
            empInt.things = new List<int>();
            empInt.things.Add(30);
            empInt.things.Add(40);

            foreach (string item in empList.things) // Loop initiated
            {
                Console.WriteLine(item);
            }

            foreach (int item in empInt.things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine(); // End program
        }
    }
}
