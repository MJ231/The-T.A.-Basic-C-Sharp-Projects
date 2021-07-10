using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a Daily Report Program
            Console.WriteLine("The Tech Academy");  // This prints the sentence "The Tech Academy"
            Console.WriteLine("Student Daily Report");  // This prints the sentence "Student Daily Report"
            Console.WriteLine("What is your name?"); // This sequence prints your name as the answer
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.WriteLine("What course are you on?"); // This sequence prints the course you are on as the answer
            string yourCourse = Console.ReadLine();
            Console.WriteLine("The course is: " + yourCourse);
            Console.WriteLine("What page number?"); // This sequence prints the page number as the answer
            string pageNumber = Console.ReadLine();
            int pagNum = Convert.ToInt32(pageNumber); // Adds the integer like "5" as an answer
            Console.WriteLine("The page number is: " + pageNumber);
            Console.WriteLine("Do you need help with anything? Please answer True or False."); // Prints the answer as "true" or "false"
            string helpMe = Console.ReadLine();
            Console.WriteLine("The answer is: " + helpMe);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics."); // This sequence prints your answer to the question
            string posEx = Console.ReadLine();
            Console.WriteLine("Specifics are: " + posEx);
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific."); // This sequence prints your answer to the question
            string feedBa = Console.ReadLine();
            Console.WriteLine("Specifics are: " + feedBa);
            Console.WriteLine("How many hours did you study today?"); // This prints hours studied
            string studyHou = Console.ReadLine();
            int houStudy = Convert.ToInt32(studyHou); // Adds the integer like "4" as an answer
            Console.WriteLine("The hours studied were: " + studyHou);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!"); // This is the end of the program 
            Console.ReadLine(); // Helps read the sentences in the command prompt
        }
    }
}
