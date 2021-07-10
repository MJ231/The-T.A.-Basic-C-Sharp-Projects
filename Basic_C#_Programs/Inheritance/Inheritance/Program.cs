using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Initialize full name
            employee.Firstname = "Sample";
            employee.Lastname = "Student";
            employee.SayName();
            Console.ReadLine(); //End program
        }
    }
}
