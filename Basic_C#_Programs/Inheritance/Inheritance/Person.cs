using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person //Create class
    {
        public string Firstname { get; set; } //Properties 
        public string Lastname { get; set; }
        public void SayName() //Void method
        {

            Console.WriteLine("Name:" + Firstname + " " + Lastname); //Display name
            Console.ReadLine(); //End program
        }
    }
}
