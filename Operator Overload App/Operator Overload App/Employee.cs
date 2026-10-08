using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overload_App
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        

        //overload == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {  
            return employee1.EmployeeID == employee2.EmployeeID;
        }
        
        //!= needs to overload too for comparison
        public static bool operator != (Employee employee1, Employee employee2)
        {
            return  employee1.EmployeeID != employee2.EmployeeID;
        }

        //overide Equals(object) method
        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.EmployeeID.Equals(emp.EmployeeID);
        }

        //override GetHashCode() method
        public override int GetHashCode()
        {
            return EmployeeID.GetHashCode();
        }
    }
}
