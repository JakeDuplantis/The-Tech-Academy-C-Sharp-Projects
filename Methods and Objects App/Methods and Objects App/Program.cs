using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate and initialize an Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Call the superclass method SayName()
            employee.SayName();
            Console.ReadLine();
        }
    }
}
