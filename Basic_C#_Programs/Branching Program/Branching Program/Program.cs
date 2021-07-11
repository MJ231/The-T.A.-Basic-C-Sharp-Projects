using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the Instructions Below.");
            Console.WriteLine("Please Enter Package Weight: ");
            double pakgWeight = Convert.ToDouble(Console.ReadLine());
            if (pakgWeight > 50)
            {
                Console.WriteLine("Package too Heavy to be Shipped via Package Express. Have a Good Day.");
            }
            else
            {
                Console.WriteLine("Please Enter Package Height: ");
                double pakgHeight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Package Width: ");
                double pakgWidth = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please Enter Package Length: ");
                double pakgLength = Convert.ToDouble(Console.ReadLine());
                double pakgSize = pakgHeight + pakgWidth + pakgLength;
                if (pakgSize > 50)
                {
                    Console.WriteLine("Package too Large to be Shipped via Package Express. Have a Good Day.");
                }
                else
                {
                    double pakgCost = (pakgHeight * pakgWidth * pakgLength * pakgWeight) / 100;
                    Console.WriteLine("Your Estimated Total for Shipping This Package is: $" + pakgCost);
                    Console.WriteLine("Thank you.");
                }


            }
            Console.ReadLine();
        }
    }
}
    

