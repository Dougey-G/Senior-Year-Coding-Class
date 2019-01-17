using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            Deck myDeck = new Deck();
            do
            {
                Console.WriteLine("1. Shuffle");
                Console.WriteLine("2. Card Draw");
                Console.WriteLine("3. Discard");
                Console.WriteLine("4. Print Deck");
                Console.WriteLine("5. Print Discard");
                Console.WriteLine("6. Exit");
                result = Console.ReadLine();

                if (result == "1")
                {
                    myDeck.Shuffle();
                    Console.WriteLine("Cards shuffled");
                    Console.WriteLine();
                }

                if (result == "2")
                {
                    myDeck.Draw();
                    Console.WriteLine();
                }

                if (result == "3")
                {
                    myDeck.Discard(new Card("suit", "face"));
                    Console.WriteLine("Card discarded");
                    Console.WriteLine();
                }

                if (result == "4")
                {
                    myDeck.PrintDeck();
                    Console.WriteLine();
                }

                if (result == "5")
                {
                    myDeck.PrintDiscard();
                    Console.WriteLine();
                }
            } while (result != "6");
        }
    }
}