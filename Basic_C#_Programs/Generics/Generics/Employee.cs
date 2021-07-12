using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T> // Name class
    {
        public string firstName { get; set; } // Name properties for generics program
        public string lastName { get; set; }
        public int employeeID { get; set; }
        public List<T> things { get; set; }
    }
}
