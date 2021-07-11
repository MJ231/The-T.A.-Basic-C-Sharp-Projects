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
            List<int> numList = new List<int>() { 25, 30, 40, 600, 755, 820 }; //Creating a string to try in a console application

            try //Testing code for errors
            {
                Console.WriteLine("What Number Would You Like To Choose To Divide?");
                int diOne = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < numList.Count; j++)  //Each loop
                {
                    int result = numList[j] / diOne;
                    Console.WriteLine(numList[j] + " divided by " + diOne + " = " + result); //Sum of equation
                }
                Console.ReadLine();
            }
            catch (FormatException ex) //Define a block of code to be executed, if error occurs
            {
                Console.WriteLine("Please Type a Whole Number.");
                return;
            }
            catch (DivideByZeroException ex) //Define a block of code to be executed, if error occurs
            {
                Console.WriteLine("Can't Divide by Zero, Sorry.");
            }
            catch (Exception ex) //Define a block of code to be executed, if error occurs
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine(); //Able to read the console application; end of program
            }
        }
    }
}