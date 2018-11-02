using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGoslin_Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] WordBank = new string[21];
            // Create an array of words to select from.
            WordBank[0] = "Nintendo Switch";
            WordBank[1] = "Nintendo 3DS";
            WordBank[2] = "Wii U";
            WordBank[3] = "Wii";
            WordBank[4] = "Nintendo DS";
            WordBank[5] = "Game Cube";
            WordBank[6] = "Game Boy Advance";
            WordBank[7] = "Nintendo 64";
            WordBank[8] = "Game Boy Color";
            WordBank[9] = "Super NES";
            WordBank[10] = "Game Boy";
            WordBank[11] = "NES";
            WordBank[12] = "Xbox One";
            WordBank[13] = "Xbox 360";
            WordBank[14] = "Xbox";
            WordBank[15] = "Play Station 4";
            WordBank[16] = "Play Station 3";
            WordBank[17] = "Play Station 2";
            WordBank[18] = "Play Station 1"; 
            WordBank[19] = "Play Station Portable";
            WordBank[20] = "Play Station Vita";
            


            // Create a random Object
            Random rand = new Random();
            // Create a string to hold our randomly selected word from the array word.
            string Word = WordBank[rand.Next(WordBank.Length)].ToLower();
            // Create a list of characters to hold our guesses
            List<char> gWord = new List<char>();
            // Create a boolean to test whether or not our solution is currently current
            bool isCorrect = false;
            // Create a counter to count the number of failed guesses
            int failedguesses = 0;
            // do while failed guesses < 6 and solution is not correct
            do
            {
                // Print out the hidden version of our string. If we print a single "_" then our solution is currently not correct.
                isCorrect = true;
                for (int i = 0; i < Word.Length; i++)
                {
                    if (gWord.Contains(Word[i]) == true)
                    {
                        Console.Write(Word[i]);
                    }
                    else
                    {
                        Console.Write("_");
                        isCorrect = false;
                    }
                }
                Console.WriteLine();

                // if our solution is currently not correct then
                if (isCorrect == false)
                {
                    // Print to the user the guesses
                    Console.WriteLine("These are the guesses so far(Correct and Incorrect)");
                    for (int i = 0; i < gWord.Count; i++)
                    {
                        Console.Write(gWord[i]);
                    }
                    Console.WriteLine();
                    // Ask the user for input
                    Console.WriteLine("Guess the Word");
                    Console.WriteLine("Catergory: Consoles");
                    Console.WriteLine("Hint: if you're stuck, add a space in (Only 3 words don't have spaces)");
                    char input = char.Parse(Console.ReadLine());

                    //if list of guesses does not contain the input then
                    if (gWord.Contains(input) == false)
                    {

                        //Add input to list of guesses
                        gWord.Add(input);
                        // if random word does not contain input then
                        if (Word.Contains(input) == false)
                        {
                            failedguesses++;
                        }
                    }
                }


                // end do while 
            } while (failedguesses < 6 && isCorrect == false);

            // Print out to the user results
            if (isCorrect == true)
            {
                Console.WriteLine("You got it correct, you guessed incorrectly " + failedguesses + " time(s)!");
            }
            else
            {
                Console.WriteLine("You ran out of guesses");
            }
            Console.ReadLine();
        }
    }
}
