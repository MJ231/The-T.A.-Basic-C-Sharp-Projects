﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start of Application
            Console.WriteLine("What is your age?"); // Answer to age limit
            string ageNum = Console.ReadLine();
            Console.WriteLine("Age is: " + ageNum);
            Console.WriteLine("Have you ever had a DUI?"); // Answer to having any DUI's
            Console.WriteLine(false && false);
            Console.WriteLine("How many speeding tickets do you have?"); // Answer to having any speeding tickets
            string speTick = Console.ReadLine();
            Console.WriteLine("Tickets claimed: " + speTick);
            Console.WriteLine("Qualified?"); // Answer to being qualified
            Console.WriteLine(true ^ false);
            Console.ReadLine();
            // End of application

            // Start of Application
            //Console.WriteLine("What is your age?"); // Answer to age limit
            //Console.WriteLine("32");
            //Console.WriteLine("Have you ever had a DUI?"); // Answer to having any DUI's
            //Console.WriteLine(false && false);
            //Console.WriteLine("How many speeding tickets do you have?"); // Answer to having any speeding tickets
            //Console.WriteLine("1");
            //Console.WriteLine("Qualified?"); // Answer to being qualified
            //Console.WriteLine(true ^ false);
            //Console.ReadLine();
            // End of application

        }
    }
}
