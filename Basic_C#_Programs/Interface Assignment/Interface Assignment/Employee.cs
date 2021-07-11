using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{
    class Employee : IQuittable // Create class
    {
        void IQuittable.Quit() // Void interface
        {
            Console.WriteLine("You Have Quit the Job.");
        }
    }
}
