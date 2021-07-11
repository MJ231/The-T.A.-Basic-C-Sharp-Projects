using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part One - Part Two
            Console.WriteLine("What is Your First Name?"); // Create an array
            string fname = Console.ReadLine();
            Console.WriteLine("What is Your Last Name?");
            string lname = Console.ReadLine();
            Console.WriteLine("What is Your Favorite Color?");
            string color = Console.ReadLine();
            Console.WriteLine("Your Name is " + fname + " " + lname + " and Your Favorite Color is " + color);

            while (true)
            {
                Console.WriteLine("This Will Never End. Close the Window."); // Loop String

            }
            while (true)
            {
                Console.WriteLine("This ReadLine Will Stop the Infinite Loop.");
                Console.ReadLine(); // End program
            }


            // Part Three
            //string[] names = { "Jeff", "Zack", "John", "Dwayne", "Mary", "Steve", "Homer" }; // Create a loop of comparisons

            //for (int j = 0; j < 7; j++) // "<" operator
            //{

            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}
            //Console.ReadLine(); // End program


            //string[] namesTwo = { "Jeff", "Zack", "John", "Dwayne", "Mary", "Steve", "Homer" }; // Create a loop of comparisons

            //for (int j = 0; j <= 7; j++) // "<=" operator
            //{
            //    {
            //        Console.WriteLine(namesTwo[j]);
            //    }
            //}
            //Console.ReadLine(); // End program

            // Part Four
            //string[] animal = { "Elephant", "Zebra", "Lion", "Tiger", "Monkey", "Giraffe" }; // Create a list of unique strings
            //Console.WriteLine("What Zoo Animal are You Looking for?"); // User input
            //string animalChoice = Console.ReadLine();
            //bool isFound = false;
            //int counter = 0;

            //while (isFound == false && counter < animal.Length)
            //{
            //    if (animal[counter] == animalChoice)
            //    {
            //        Console.WriteLine("The Animal, " + animalChoice + ", is Located at Index #" + counter); // Correct animal and index
            //        isFound = true;
            //    }
            //    counter++;
            //}
            //if (isFound == false)
            //{
            //    Console.WriteLine("We Don't Have that Animal at This Zoo."); // Wrong option of choice
            //}
            //Console.ReadLine(); // End program


            // Part Five
            //List<string> namesThree = new List<string>() { "Jeff", "Zack", "John", "Dwayne", "Jeff", "Steve", "Homer" }; // Create two identical strings
            //Console.WriteLine("What Name are You Searching for?"); // User input
            //string nameSelect = Console.ReadLine();
            //bool isfound = false;

            //for (int j = 0; j < namesThree.Count; j++)
            //{
            //    if (namesThree[j] == nameSelect)
            //    {
            //        Console.WriteLine("We Found the Name, " + nameSelect + ", in the Following Index: " + j); // Listed from index
            //        isfound = true;
            //    }

            //}
            //if (isfound == false)
            //{
            //    Console.WriteLine("A Match Wasn't Listed."); // Not listed from the string
            //}
            //Console.ReadLine(); // End program


            // Part Six
            //List<string> food = new List<string>() { "Lobster", "Steak", "Crab", "Pasta", "Steak", "Lobster" }; // Create two identical strings
            //List<string> foodBack = new List<string>();

            //foreach (var element in food)
            //{
            //    foreach (var element2 in foodBack)
            //    {
            //        if (element == element2)
            //        {
            //            Console.WriteLine("This Item, " + element + ", Has Been Found on the List."); // Listed from element
            //        }

            //    }
            //    foodBack.Add(element);

            //}
            //Console.ReadLine(); // End program

        }

    }           
}