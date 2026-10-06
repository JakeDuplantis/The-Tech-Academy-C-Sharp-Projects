using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_App
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public virtual void SayName()
        {
            //can be overridden
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + " " + "[" + fullName + "]");
        }
    }
}
