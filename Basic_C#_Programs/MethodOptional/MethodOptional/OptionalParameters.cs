using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptional
{
    public class OptionalParameters // Class name
    {
        public void optionalModifier(int x, int y = 0) // Name parameters
        {
            this.x = x * 10; // Give parameters an equation
            this.y = y + 10;
        }

        public int x { get; set; } // Integers are void
        public int y { get; set; }
    }
}