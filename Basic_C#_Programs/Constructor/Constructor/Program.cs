using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MovieTitle = "Black Widow"; // Constructor of movie title
            var PaidSeat = "Row 3, Seat 10"; // Variable of paid seat 
            Console.WriteLine("Enjoy Today's Feature Film: {0}", MovieTitle); // Display message on console application
            Console.WriteLine("You Seat is " + PaidSeat); // Display message on console application
            Console.ReadLine(); // End program
        }
    }
}
