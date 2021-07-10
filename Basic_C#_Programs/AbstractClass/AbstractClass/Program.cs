using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //Instantiate employee object
            employee.FirstName = "Sample"; //Display name
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine(); //End program
        }
    }
}
