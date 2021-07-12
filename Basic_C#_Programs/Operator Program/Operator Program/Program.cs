using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            employee1.id = 001;
            employee1.sayName();

            Employee employee2 = new Employee();
            employee2.firstName = "Dirk";
            employee2.lastName = "Henderson";
            employee2.id = 002;
            employee2.sayName();

            Employee employee3 = new Employee();
            employee3.firstName = "Jacob";
            employee3.lastName = "Coo";
            employee3.id = 003;
            employee3.sayName();

           Console.ReadLine();
        }
    }
}
