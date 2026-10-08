using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums_App
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please enter the current day of the week");
                string currentDay = Console.ReadLine();
                //makes currentDay case in-sensitive by spliting string then making the first character uppercase then concatenate
                currentDay = currentDay.Substring(0, 1).ToUpper() + currentDay.Substring(1).ToLower();

                try
                {
                    //convert input to enum
                    Days day = (Days)Enum.Parse(typeof(Days), currentDay);
                    Console.WriteLine("Today is " + day);
                    break;
                }
                catch
                {
                    Console.WriteLine("not a valid day of the week");
                }
            }
            Console.ReadLine();

        }
        public enum Days
        { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
