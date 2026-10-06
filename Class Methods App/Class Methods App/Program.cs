using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Methods_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mathMethod mathThings = new mathMethod();

            Console.WriteLine("Please enter a number to divide by 2");
            int userInput = Convert.ToInt32(Console.ReadLine());

            //call method
            mathThings.mathStuff(userInput);
            Console.ReadLine();

            
            //instantiate
            mathMethod mathThings2 = new mathMethod();
            Console.WriteLine("enter first of two numbers");
            double Input1 = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine("enter the second number");
            double Input2 = Convert.ToDouble(Console.ReadLine());
            //call overload meathod
            double result;
            mathThings2.mathStuff2(Input1, Input2, out result);
            Console.ReadLine();


            //call static class method
            Console.WriteLine("enter first of two numbers");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int Result = mathMethodStatic.AddStuff(input1, input2);
            Console.WriteLine(input1 + " plus " + input2 + " equals " + Result);
            Console.ReadLine();
        }

        //static class
        public static class mathMethodStatic 
        {
            public static int AddStuff(int a, int b)
            { 
                return a + b;
            }
        }

    }
}
