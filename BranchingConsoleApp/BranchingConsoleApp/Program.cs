using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");

            Console.WriteLine("Please enter the package weight:");
            decimal packageWgt = Convert.ToDecimal(Console.ReadLine());     //All variables are decimal for math operations and decimal is preferred in money calculations.

            if (packageWgt > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            Console.WriteLine("Please enter the package width:");
            decimal packageWdth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            decimal packageHgt = Convert.ToDecimal(Console.ReadLine());   

            Console.WriteLine("Please enter the package length:");
            decimal packageLgth = Convert.ToDecimal(Console.ReadLine());

            decimal packageDims = packageWdth * packageHgt * packageLgth;

            if (packageDims > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            decimal shippingTotal = (packageDims * packageWgt) / 100;       //shippingTotal is decimal to prevent small packages from costing $0
            Console.WriteLine("Your estimated total for shipping this package is: " + "$" + Math.Round(shippingTotal, 2, MidpointRounding.ToEven));   //Math.Round() method to round to the nearest cent

            Console.WriteLine("Thank you!");

            Console.ReadLine(); 
        }
    }
}
