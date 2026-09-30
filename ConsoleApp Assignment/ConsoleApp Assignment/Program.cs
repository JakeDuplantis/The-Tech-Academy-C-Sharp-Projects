using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A one-dimensional array of strings.
            string[] books = { "The Hobbit", "Dune", "Frankenstein" };

            //Ask the user to input some text.
            Console.WriteLine("Please enter some text to add at the end of the strings");
            string userInput = Console.ReadLine();

            //A loop that iterates through each string in the array and adds the user's text input to the end of each string. 
            for (int i = 0; i < books.Length; i++)    
            {
                Console.WriteLine(books[i] + " " + userInput);
            }
            Console.ReadLine();

            // a loop that prints off each string in the array on a separate line.
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i] + "\n");
            }
            Console.ReadLine();



            //An infinite loop.
            //while (true)
            //{
            //    Console.WriteLine("infinite loop");
            //}

            //Fix the infinite loop so that it will execute properly.
            Console.WriteLine("working loop");
            int num = 0;
            while (num <= 5) 
            { 
                Console.WriteLine("loop count " + num);
                num++; //increment needed or will loop infintely
            }
            Console.ReadLine();



            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a  “<” operator.
            Console.WriteLine("X less than");
            int X = 0;
            while (X < 6)
            {
                Console.WriteLine(X);
                X++;
            }
            Console.ReadLine();


            //A loop where the comparison that’s used to determine whether to continue iterating the loop is a “<=” operator.
            Console.WriteLine("Y less than or equal");
            int Y = 10;
            while (Y <= 13)
            {
                Console.WriteLine(Y);
                Y++;
            }
            Console.ReadLine();


            //list of strings where each item in the list is unique.
            List<string> names = new List<string>() { "Jeff", "Terry", "Mike", "Elsa" };

            //Ask the user to input text to search for in the list.
            Console.WriteLine("Please select a name from the list");
            string listinput = Console.ReadLine().ToLower();

            //A loop that iterates through the list and then displays the index of the list that contains matching text on the screen
            for (int j = 0; j < names.Count; j++)
            {
                if (names[j].ToLower() == listinput)         
                {
                    Console.WriteLine("found at index: " + j); 
                }      
            }
            Console.ReadLine();


            //A list of strings that has at least two identical strings in the list. Ask the user to select text to search for in the list.
            List<string> fruitList = new List<string>() { "Apple", "Pear", "Orange", "Apple"};
            Console.WriteLine("select fruit to search in list");
            string fruitinput = Console.ReadLine().ToLower();
            

            //Create a loop that iterates through the loop and then displays the indices of the list that contain matching text on the screen.
            
            bool fruitFound = false;        
            for (int k = 0; k < fruitList.Count; k++)
            {
                if (fruitList[k].ToLower() == fruitinput)
                {
                    fruitFound = true;
                    Console.WriteLine("Match found at index " + k);    
                }
            }
            //Add code to the loop that tells a user if they put in text that isn’t in the list.
            if (!fruitFound)
            {
               Console.WriteLine("There were no matches for " + fruitinput);
            }
            Console.ReadLine();



            //Create a list of strings that has at least two identical strings in the list.
            List<string> animals = new List<string>() { "cow", "horse", "chicken", "cow" };
            Console.WriteLine("animals list");

            //Create a foreach loop that evaluates each item in the list, and displays a message showing the string and whether or not it has already appeared in the list.
            List<string>animalsFound = new List<string>(); //empty list
            foreach (string animal in animals)
            {                           
                if (animalsFound.Contains(animal))
                {
                    Console.WriteLine("The animal " + animal + " has already been added");
                }
                else
                {
                    Console.WriteLine(animal + " was added");
                    animalsFound.Add(animal);
                }             
            }
            Console.ReadLine();
        }
    }
}
