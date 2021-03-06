using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Program
            int i = 0;
            while (i < 30)
            {
                Console.WriteLine(i);
                i++;
            }
            
            Console.WriteLine("Guess my age?"); // Print message
            int age = Convert.ToInt32(Console.ReadLine()); // Convert into integers
            bool isGuessed = age == 30; // equal to correct age

            do // Do loop
            {
                switch (age)
                {
                    case 29: // First case
                        Console.WriteLine("You guessed 29. Try again."); // Wrong answer
                        Console.WriteLine("Guess an age?"); // Print message
                        age = Convert.ToInt32(Console.ReadLine()); // Convert into integers
                        break;
                    case 31: // Second case
                        Console.WriteLine("You guessed 31. Try again."); // Wrong answer
                        Console.WriteLine("Guess an age?"); // Print message
                        age = Convert.ToInt32(Console.ReadLine()); // Convert into integers
                        break;
                    case 40: // Third case
                        Console.WriteLine("You guessed 40. Try again."); // Wrong answer
                        Console.WriteLine("Guess an age?"); // Print message
                        age = Convert.ToInt32(Console.ReadLine()); // Convert into integers
                        break;
                    case 30: // Fourth case
                        Console.WriteLine("You guessed 30. That is correct!"); // Correct answer
                        isGuessed = true; // Becomes a true statement
                        break;
                    default: // Default answer when wrong
                        Console.WriteLine("You are wrong."); // Print message
                        Console.WriteLine("Guess an age?"); // Print message
                        age = Convert.ToInt32(Console.ReadLine()); // Convert into integers 
                        break;
                }
            }
            while (!isGuessed); // While loop 

            Console.Read();
            // End Program
        }
    }
}
