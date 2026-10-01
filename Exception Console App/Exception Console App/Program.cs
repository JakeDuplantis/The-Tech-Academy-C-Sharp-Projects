using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Console_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 10, 20, 30 };

            bool inputValid = false;
            while (!inputValid) //while loop to loop input attempts
            {             
                try
                {
                    Console.WriteLine("enter a number to divide list numbers by");
                    string userInput = Console.ReadLine();

                    foreach (int number in numberList)
                    {
                        Console.WriteLine(number + " divided by " + userInput);
                        Console.WriteLine( number / Convert.ToDecimal(userInput)); //decimal type to get accurate result and avoid infinity when dividing by double or float
                        
                        inputValid = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a whole number");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Please don't divide by zero");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                        
            }
            Console.WriteLine("input valid exiting try/catch ");
            Console.ReadLine();
        }
    }
}
