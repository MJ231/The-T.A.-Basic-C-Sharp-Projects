using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>(); // Integrate employee class

            employeeList.Add(new Employee() { FirstName = "Neil", LastName = "Dawn", EmployeeID = 001 }); // Give ten employees names and id's 
            employeeList.Add(new Employee() { FirstName = "Paige", LastName = "Tatum", EmployeeID = 002 });
            employeeList.Add(new Employee() { FirstName = "Joe", LastName = "King", EmployeeID = 003 });
            employeeList.Add(new Employee() { FirstName = "Holly", LastName = "Nights", EmployeeID = 004 });
            employeeList.Add(new Employee() { FirstName = "Barb", LastName = "Blurr", EmployeeID = 005 });
            employeeList.Add(new Employee() { FirstName = "Justin", LastName = "Coo", EmployeeID = 006 });
            employeeList.Add(new Employee() { FirstName = "Robin", LastName = "Banks", EmployeeID = 007 });
            employeeList.Add(new Employee() { FirstName = "Anna", LastName = "Gray", EmployeeID = 008 });
            employeeList.Add(new Employee() { FirstName = "Joe", LastName = "Kerr", EmployeeID = 009 });
            employeeList.Add(new Employee() { FirstName = "Terry", LastName = "Funk", EmployeeID = 010 });

            Console.WriteLine("Employee List:");
            foreach (Employee emp in employeeList)
            {
                //Console.WriteLine("Employee List: \nFirst Name: {0} \tLast Name: {1} \tId: {2}", emp.FirstName, emp.LastName, emp.EmployeeId);
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " Id: " + emp.EmployeeID); // Output employee names

            }

            Console.WriteLine("\nEmployees with the First Name Joe:");
            List<Employee> joeList = new List<Employee>(); // Integrate employee class
            foreach (Employee joeEmp in employeeList)
            {
                if (joeEmp.FirstName == "Joe")
                {
                    joeList.Add(joeEmp);
                    Console.WriteLine("First Name: {0} \tLast Name: {1} \tId: {2}", joeEmp.FirstName, joeEmp.LastName, joeEmp.EmployeeID); // Output "Joe" name
                }
            }

            Console.WriteLine("\nEmployees with First Name Joe:");
            foreach (Employee empJoe in employeeList.FindAll(x => x.FirstName == "Joe")) // Display output of only "Joe"
            {
                Console.WriteLine("First Name: {0} Last Name: {1} Id: {2}", empJoe.FirstName, empJoe.LastName, empJoe.EmployeeID); // Output "Joe" name
            }

            Console.WriteLine("\nEmployee Id #'s Over 5: ");
            foreach (Employee idNum in employeeList.FindAll(x => x.EmployeeID > 5)) // Display employee id's greater than five 
            {
                Console.WriteLine("Id # {0}: {1} {2}", idNum.EmployeeID, idNum.FirstName, idNum.LastName); // Output employee names
            }
            Console.ReadLine(); // End program
        }
    }
}
