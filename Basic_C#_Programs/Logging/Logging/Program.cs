using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\doubl\logs\log.txt";
            Console.WriteLine("Type in a Number:");
            string inputNum = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(inputNum);
            }
            using (StreamReader file = new StreamReader(filePath, true))
            {
                string returnText = file.ReadToEnd().ToString();
                Console.WriteLine(returnText);
            }
            Console.ReadLine();
        }
    }
}
