using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person //Create class
    {
        public string FirstName { get; set; } //String of name
        public string LastName { get; set; }
        public abstract void SayName(); //Void method 
    }
}
