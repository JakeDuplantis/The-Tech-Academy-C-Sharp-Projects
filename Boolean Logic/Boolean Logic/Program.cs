using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Logic
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            bool resultAge = Convert.ToInt32(age) > 15;
            
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\". " );
            string DUI = Console.ReadLine();
            bool resultDUI = Convert.ToBoolean(DUI);   //doesn't work if not true/false
      
            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            bool resultTickets = Convert.ToInt32(tickets) < 3;

            Console.WriteLine("Qualified?");
            bool isQualified = (resultAge && !resultDUI && resultTickets);
         
            Console.WriteLine(isQualified);

            Console.ReadLine();
        }
    }
}
