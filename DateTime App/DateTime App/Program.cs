using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DateTime_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The current date and time is " + currentTime);

            Console.WriteLine("Please enter a number for hours to add");
            int inputHours = Convert.ToInt32(Console.ReadLine());

            DateTime timeInHours = currentTime.AddHours(inputHours);
            Console.WriteLine("In {0} hours the time will be {1}", inputHours, timeInHours);

            Console.ReadLine();
        }
    }
}
