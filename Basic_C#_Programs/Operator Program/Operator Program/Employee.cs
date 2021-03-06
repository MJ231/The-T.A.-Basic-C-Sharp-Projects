using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Program
{
    public class Employee : Person, IQuittable
    {
        public int id { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.id == employee2.id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.id != employee2.id;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override bool Equals(object o)
        {
            return false;
        }
        public override void sayName()
        {
            Console.WriteLine("Full Name: {0} {1} \nID Number: {2}", firstName, lastName, id);
        }

        public void Quit(Person person)
        {
            Console.WriteLine("\n{0} {1} has Quit.", firstName, lastName);
        }

        internal void Quit()
        {
            throw new NotImplementedException();
        }
    }
}
