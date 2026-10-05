using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method instantiate the class and call the first method, passing in an integer. Display the result to the screen.
            mathMethod mathThingsAdd5 = new mathMethod();

            int numA = mathThingsAdd5.mathStuff(5);
            Console.WriteLine(numA);


            //In the Main() method instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            mathMethod mathThingsDiv2 = new mathMethod();

            int numB = Convert.ToInt32(mathThingsDiv2.mathStuff(3.66m));//m needed to pass decimal
            Console.WriteLine(numB);


            //In the Main() method instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            mathMethod mathThingsX3 = new mathMethod();

            int numC = Convert.ToInt32(mathThingsX3.mathStuff("10"));            
            Console.WriteLine(numC);
            

            Console.ReadLine();
        }
    }
}
