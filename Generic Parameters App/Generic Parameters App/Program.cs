using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Parameters_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "apple", "orange", "bananna" };

            //Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.
            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int> { 5, 10, 15, 20 };

            //loop to print string Things
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }

            //loop to print int Things
            foreach (int thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
