using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask the user what number they want to do the math operations on
            Console.WriteLine("enter an integer to do math operations on");
            int userInput = Convert.ToInt32(Console.ReadLine());


            //Call each method
            mathMethods mathThings = new mathMethods(); //mathMethods instantiated

            int addTen = mathThings.add10(userInput);
            Console.WriteLine(userInput + " plus 10" + " equals " + addTen);

            int multiplyThree = mathThings.multiply3(userInput);
            Console.WriteLine(userInput + " times 3" + " equals " + multiplyThree);

            int subtractFive = mathThings.subtract5(userInput);
            Console.WriteLine(userInput + " minus 5" + " equals " + subtractFive);


            Console.ReadLine();
        }
    }
}
