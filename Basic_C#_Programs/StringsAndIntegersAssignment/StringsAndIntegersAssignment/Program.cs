using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            RetryPoint:
            
            try //Testing code for errors
            {
                List<int> numList = new List<int>() { 25, 30, 40, 600, 755, 820 }; //Creating a string to try in a console application
                Console.WriteLine("What Number Would You Like To Choose To Divide?");
                int diOne = Convert.ToInt32(Console.ReadLine());

                foreach(int i in numList)  //Each loop
                {

                    Console.WriteLine(i / diOne); //Sum of equation
                }
                
            }
            catch (FormatException ex) //Define a block of code to be executed, if error occurs
            {
                Console.WriteLine("Please Type a Whole Number.");
                goto RetryPoint;
            }
            catch (DivideByZeroException ex) //Define a block of code to be executed, if error occurs
            {
                Console.WriteLine("Can't Divide by Zero, Sorry.");
                goto RetryPoint;
            }
            Console.WriteLine("Thank You, Your Input was a Non-Zero Integer and the Program has Finished.");
            Console.ReadLine(); //Able to read the console application; end of program
            
        }
    }
}