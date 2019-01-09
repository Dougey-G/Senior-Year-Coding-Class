using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            // This code will have the computer pick the number, and have the user guess the number
            Random rand = new Random();

            // Create a random generated number loop between 0 and 1000, which will pick a random number
            int GuessNumber = rand.Next(0, 1000);


            // Create a variable that will keep track of the amount of times that the user guesses
            int NumberTries = 0;

            // Allow user input for numbers between 0 - 1000.
            int input = 0;

            // Use while loop to have the user guess the number

            while (GuessNumber != input)
            {
                Console.WriteLine("Guess");
                input = int.Parse(Console.ReadLine());
                NumberTries++;
                // Allow program to say if the picked number is higher than the guessed number
                if (input > GuessNumber)
                    Console.WriteLine("Guess Lower");
                // Allow program to say if the picked number is lower than the guessed number
                if (input < GuessNumber)
                    Console.WriteLine("Guess Higher");


                // Create a WriteLine, which will tell the user when they get the number correct,
                // and show how many tries it took for the user to guess the number.
                if (input == GuessNumber)
                {

                    Console.WriteLine("You guessed corectly, it took you" + " " + NumberTries + " " + "times to get it right.");
                    Console.ReadLine();
                }
                // (when number is guessed, add 1 guess to the total amount of guesses)
                // Create exit program code
            }
        }
    }
}





