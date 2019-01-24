using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Card
    {
            public string face;
            public string suit;
            public Card(string suit, string face)
            {
                this.suit = suit;
                this.face = face;
            }
        
        public void Print()
        {
            //needs to print the cards specific face and suit
            Console.WriteLine("-----------------");
            Console.WriteLine("|" + suit + "of" + face +"|");
            Console.WriteLine("-----------------");
        }
    }
}
