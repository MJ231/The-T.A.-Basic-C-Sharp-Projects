using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person //Create class
    {
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName); //Display name
        }
    }
}
