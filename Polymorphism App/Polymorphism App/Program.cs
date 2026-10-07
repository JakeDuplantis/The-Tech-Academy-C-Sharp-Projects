using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Use polymorphism to create an object of type IQuittable
            IQuittable quit = new Employee();       

            //call Quit() method
            quit.Quit();

            Console.ReadLine();
        }
    }
}
