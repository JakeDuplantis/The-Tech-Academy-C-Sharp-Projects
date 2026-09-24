using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_income_comparison_program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Anomymous income Comparison Program");

            //person1
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly rate?");
            string p1_Rate = Console.ReadLine();
            Convert.ToInt32(p1_Rate);
            Console.WriteLine("Person1 rate is " + p1_Rate);

            Console.WriteLine("Hours worked per week?");
            string p1_HoursWorked = Console.ReadLine();
            Convert.ToInt32(p1_HoursWorked);
            Console.WriteLine("Person1 worked " + p1_HoursWorked + " hours");

            //person2
            Console.WriteLine("Person2");
            Console.WriteLine("Hourly rate?");
            string p2_Rate = Console.ReadLine();
            Console.WriteLine("Person2 rate is " + p2_Rate);

            Console.WriteLine("Hours worked per week?");
            string p2_HoursWorked = Console.ReadLine();
            Console.WriteLine("Person2 worked " + p2_HoursWorked + " hours");

            Console.WriteLine("Annual Salary of Person 1:");
            int Annualsalary1 = Convert.ToInt32(p1_Rate) * Convert.ToInt32(p1_HoursWorked) * 52;
            Console.WriteLine(Annualsalary1);

            Console.WriteLine("Annual Salary of Person 2:");
            int Annualsalary2 = Convert.ToInt32(p2_Rate) * Convert.ToInt32(p2_HoursWorked) * 52;
            Console.WriteLine(Annualsalary2);

            Console.WriteLine("Does Person 1 make more money than person 2?");
            bool salCheck = Annualsalary1 > Annualsalary2;
            Console.WriteLine(salCheck);

            Console.ReadLine();
        }
    }
}
