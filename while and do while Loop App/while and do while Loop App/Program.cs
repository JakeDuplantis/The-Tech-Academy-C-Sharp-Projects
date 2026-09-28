using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_and_do_while_Loop_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a color?");
            string color = Console.ReadLine();

            bool guessedColor = color == "red"; //if red is guessed first the while loop will not be executed

            while (!guessedColor)
            {
                switch (color)
                {
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed the color red. That is correct!");
                        guessedColor = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a color?");
                        color = Console.ReadLine();
                        break;

                }
            }
            Console.ReadLine();



            Console.WriteLine("Guess an animal?");      
            string animal = Console.ReadLine();

            bool guessedAnimal = animal == "cat";

            do //even if the first guess is cat the while loop is executed
            {
                switch (animal)
                {
                    case "dog":
                        Console.WriteLine("You guessed dog. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "rabbit":
                        Console.WriteLine("You guessed rabbit. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "fish":
                        Console.WriteLine("You guessed fish. Try again.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;
                    case "cat":
                        Console.WriteLine("You guessed the animal cat. That is correct!");
                        guessedAnimal = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess an animal?");
                        animal = Console.ReadLine();
                        break;

                }
            }
            while (!guessedAnimal); 

            Console.Read();













        }
    }
}
