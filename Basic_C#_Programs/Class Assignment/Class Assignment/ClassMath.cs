using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    public class ClassMath // Name class
    {
        public void Division(int x, out int y) // Void method
        {
            y = x / 2;
        }
        
        public static void Division(decimal w, out decimal z) // More methods
        {
            z = w / 2;
        }

        int x { get; set; } // Display integers 
        int y { get; set; }
        decimal w { get; set; } // Display Decimal integers
        decimal z { get; set; }
    }
}
