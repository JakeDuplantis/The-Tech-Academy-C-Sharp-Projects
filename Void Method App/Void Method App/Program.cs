using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Method_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathMethod mathThings = new mathMethod();

            //Call the method in the class, passing in two numbers.
            mathThings.mathStuff(5, 2);//cannot assign void method to a variable


            //Call the method in the class, specifying the parameters by name.
            mathThings.mathStuff(numX: 4, numY: 3);

            Console.ReadLine();
        }
    }
}
