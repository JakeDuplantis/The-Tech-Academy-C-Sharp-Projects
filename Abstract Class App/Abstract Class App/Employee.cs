using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_App
{
    public class Employee : Person
    {
        public override void SayName() 
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + " " + "[" + fullName + "]");
        }
    }
}
