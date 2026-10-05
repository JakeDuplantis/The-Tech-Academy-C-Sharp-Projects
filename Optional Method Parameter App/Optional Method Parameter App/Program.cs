using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Method_Parameter_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathIntegers mathThings = new mathIntegers();

            Console.WriteLine("Please enter the first of two numbers to add");
            int inputNum1 = Convert.ToInt32(Console.ReadLine());



            int result;
            Console.WriteLine("Enter the second number, it is not necessary");
            bool inputNum2Valid = int.TryParse(Console.ReadLine(), out int inputNum2);
            //pressing enter with no value returns empty string which can't be converted to int.
            //bool to check if input is valid for int conversion, if not results leaves it out and intial parameter value is applied

            if (inputNum2Valid)
            {
                result = mathThings.mathStuff(inputNum1, inputNum2);
            }
            else
            {
                result = mathThings.mathStuff(inputNum1);
            }


            Console.WriteLine(inputNum1 + " plus " + inputNum2 + " equals " + result);

            Console.ReadLine();
        }
    }
}
