using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicle = new string[4] { "sedan", "SUV", "pickup truck", "van" };

            Console.WriteLine("Please select an index of vehicle array");
            int vehiclechoice = int.Parse(Console.ReadLine());

            if (vehiclechoice < 0 || vehiclechoice > vehicle.Length - 1)    //if statement for when input index is outside of array
            {
                Console.WriteLine("invalid input. index is outside the array");
                return;
            }
            else                                                            //else statement for when input index is inside of array
            {
                Console.WriteLine(vehicle[vehiclechoice].ToString());
            }




            int[] number = new int[4] { 5, 10, 15, 20 };

            Console.WriteLine("Please select an index of number array");
            int numberchoice = int.Parse(Console.ReadLine());

            if (numberchoice < 0 || numberchoice > number.Length - 1)       //if statement for when input index is outside of array
            {
                Console.WriteLine("invalid input. index is outside the array");
                return;
            }
            else                                                            //else statement for when input index is inside of array
            {
                Console.WriteLine(number[numberchoice]);
            }



            List<string> fruitList = new List<string>() {"Apple", "Pear", "Orange" };

            Console.WriteLine("Please select an index of fruit list");
            int fruitChoice = int.Parse(Console.ReadLine());

            if (fruitChoice < 0 || fruitChoice > fruitList.Count - 1)
            {
                Console.WriteLine("invalid input. index is outside the list");
                return;
            }
            else
            {
                Console.WriteLine(fruitList[fruitChoice]);
            }

            Console.ReadLine();
        }
    }
}
