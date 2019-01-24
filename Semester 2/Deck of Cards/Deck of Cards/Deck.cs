using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck_of_Cards
{
    class Deck
    {
        List<Card> myDeck = new List<Card>();

        List<Card> discard = new List<Card>();
        public Deck()
        {
            myDeck.Add(new Card("Spade ", " Ace"));
            myDeck.Add(new Card("Hearts ", " Ace"));
            myDeck.Add(new Card("Diamonds ", " Ace"));
            myDeck.Add(new Card("Clubs ", " Ace"));
            myDeck.Add(new Card("Spade ", " Two"));
            myDeck.Add(new Card("Hearts ", " Two"));
            myDeck.Add(new Card("Diamonds ", " Two"));
            myDeck.Add(new Card("Clubs ", " Two"));
            myDeck.Add(new Card("Spade ", " Three"));
            myDeck.Add(new Card("Hearts ", " Three"));
            myDeck.Add(new Card("Diamonds ", " Three"));
            myDeck.Add(new Card("Clubs ", " Three"));
            myDeck.Add(new Card("Spade ", " Four"));
            myDeck.Add(new Card("Hearts ", " Four"));
            myDeck.Add(new Card("Diamonds ", " Four"));
            myDeck.Add(new Card("Clubs ", " Four"));
            myDeck.Add(new Card("Spade ", " Five"));
            myDeck.Add(new Card("Hearts ", " Five"));
            myDeck.Add(new Card("Diamonds ", " Five"));
            myDeck.Add(new Card("Clubs ", " Five"));
            myDeck.Add(new Card("Spade ", " Six"));
            myDeck.Add(new Card("Hearts ", " Six"));
            myDeck.Add(new Card("Diamonds ", " Six"));
            myDeck.Add(new Card("Clubs ", " Six"));
            myDeck.Add(new Card("Spade ", " Seven"));
            myDeck.Add(new Card("Hearts ", " Seven"));
            myDeck.Add(new Card("Diamonds ", " Seven"));
            myDeck.Add(new Card("Clubs ", " Seven"));
            myDeck.Add(new Card("Spade ", " Eight"));
            myDeck.Add(new Card("Hearts ", " Eight"));
            myDeck.Add(new Card("Diamonds ", " Eight"));
            myDeck.Add(new Card("Clubs ", " Eight"));
            myDeck.Add(new Card("Spade ", " Nine"));
            myDeck.Add(new Card("Hearts ", " Nine"));
            myDeck.Add(new Card("Diamonds ", " Nine"));
            myDeck.Add(new Card("Clubs ", " Nine"));
            myDeck.Add(new Card("Spade ", " Ten"));
            myDeck.Add(new Card("Hearts ", " Ten"));
            myDeck.Add(new Card("Diamonds ", " Ten"));
            myDeck.Add(new Card("Clubs ", " Ten"));
        }

        public void Shuffle()
        {
            myDeck = myDeck.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public Card Draw()
        {
            Card Top = myDeck[myDeck.Count - 1];
            myDeck.RemoveAt(myDeck.Count - 1);
            Top.Print();


            return Top;
        }

        public void Discard(Card c)
        {
            discard.Add(c);
        }

        public void PrintDeck()
        {
            for (int i = 0; i < myDeck.Count; i++)
            {
                myDeck[i].Print();
            }
        }

        public void PrintDiscard()
        {
            for (int i = 0; i < discard.Count; i++)

            {
                discard[i].Print();
            }
        }
    }
}