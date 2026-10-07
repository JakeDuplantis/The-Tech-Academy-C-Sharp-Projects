using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_App
{
    public class Employee :  IQuittable
    {
        public void Quit()
        {
            Console.WriteLine(EmployeeName +  " Said \"I quit\". ");
        } 
        public string EmployeeName = "Bob";
    }
}
