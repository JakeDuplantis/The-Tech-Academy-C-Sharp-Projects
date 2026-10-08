using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instantiate first employee
            Employee employee1 = new Employee();

            employee1.Name = "John";
            employee1.EmployeeID = 117;

            //instantiate second employee
            Employee employee2 = new Employee();

            employee2.Name = "Mike";
            employee2.EmployeeID = 123;


            if (employee1 == employee2)
            {
                Console.WriteLine( employee1.Name + "\'s" + " employee ID" + " is equal to " + employee2.Name + "\'s ID");
            }
            else 
            {
                Console.WriteLine(employee1.Name + "\'s" + " employee ID" + " is not equal to " + employee2.Name + "\'s ID");
            }


            Console.ReadLine();
        }
    }
}
