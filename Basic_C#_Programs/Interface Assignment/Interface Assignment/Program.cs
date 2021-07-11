using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    class Program : Employee // Integrate class
    {
        static void Main(string[] args)
        {
            IQuittable quitExe = new Employee(); // Integrate interface with class
            quitExe.Quit(); // Quit method
            Console.ReadLine(); // End Program
        }
    }
}
