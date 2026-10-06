using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects_App
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName() 
        {
            string fullName =  FirstName + " " + LastName ;
            Console.WriteLine("Name: " + " " + "[" + fullName + "]");
        }
    }
}
