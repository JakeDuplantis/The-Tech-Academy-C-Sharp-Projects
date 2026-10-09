using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_App
{
    public class Employee
    {
        public int EmpID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //constructor
        public Employee(int empID, string firstName, string lastName)
        {
            EmpID = empID;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
