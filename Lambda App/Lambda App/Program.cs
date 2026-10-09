using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List of Employees
            List<Employee> employee = new List<Employee>()
            {
                new Employee(1, "Joe",  "Wheeler"),
                new Employee(2, "Joe", "Murray"),
                new Employee(3, "Brett", "Moore"),
                new Employee(4, "Darien", "Scott"),
                new Employee(5, "Skylar", "Reese"),
                new Employee(6, "Robert", "Johnson"),
                new Employee(7, "Heather", "Adams"),
                new Employee(8, "Clark", "Walker"),
                new Employee(9, "Zack", "Stafford"),
                new Employee(10, "Cindy", "Banks")

            };

            //list of all employees with the first name "Joe" using a foreach loop
            List<Employee> namedJoe = new List<Employee>();

            string searchName = "Joe";
            foreach (Employee emp in employee)
            {
                if (emp.FirstName == searchName)
                {
                    namedJoe.Add(emp);
                    Console.WriteLine(emp.FirstName + " " + emp.LastName);
                }
            }
            Console.ReadLine();


            //list of all employees with the first name "Joe" using lambda expression
            List<Employee> NamedJoe = employee.Where(name => name.FirstName == "Joe").ToList();

            foreach (Employee emp in NamedJoe)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            Console.ReadLine();



            //list of all employees with an Id number greater than 5 using lambda expression
            List<Employee> HigherID = employee.Where(id => id.EmpID > 5).ToList();

            foreach (Employee emp in HigherID)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }
            Console.ReadLine();
        }
    }
}
