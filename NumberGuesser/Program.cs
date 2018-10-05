using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            Console.WriteLine("Welcome to Number Guesser!"); 

            while (true)
            {
                // create a random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                Console.WriteLine("Pick a number between 1 and 10: ");

                // while guess is not correct
                while( guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    //check if it's a number
                    if(!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");

                        // keep going
                        continue;
                    }

                    //cast to int
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if(guess != correctNumber)
                    {
                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number! Try again: ");

                    }
                }

                //print succes message
                PrintColorMessage(ConsoleColor.Yellow, "You're correct!");

                AskToPlayAgain();

                //ask to play again
                Console.WriteLine("Play again? [Y o N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    // clear console
                    Console.Clear();
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        static void GetAppInfo() // Aplication Info
        {
            string appName = "Number Guesser";
            string appVersion = "1.0";
            string appAuthor = "Mateusz Celka";
            Console.WriteLine("{0} version: {1} by {2}", appName, appVersion, appAuthor);
        }
        
        static void PrintColorMessage(ConsoleColor color, string message) //Change text color
        {
            // change color
            Console.ForegroundColor = color;

            // show message
            Console.WriteLine(message);

            // resset color
            Console.ResetColor();
        }

        static void AskToPlayAgain()
        {

        }


    }
}
