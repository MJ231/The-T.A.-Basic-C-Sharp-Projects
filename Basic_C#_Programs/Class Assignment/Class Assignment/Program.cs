using System;


namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassMath methodOne = new ClassMath(); // Initiate from class
            Console.WriteLine("Please Enter a Whole Number:"); // User input
            int answerOne = Convert.ToInt32(Console.ReadLine()); // Convert answer to whole number
            ClassMath.NumberMethod(out int resultMain, answerOne);
            Console.WriteLine(resultMain); // Results of answerOne
            Console.ReadLine(); // End program
        }
    }
}