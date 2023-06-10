using BlackJack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClasses;

namespace Lab6
{
    public class Hand
    {
        protected List<Card> cards;

        public int IndexOf(Card c)
        {
            return cards.IndexOf(c);
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }

        public int IndexOf(int value, int suit)
        {
            return cards.IndexOf(cards[value]);
        }
       
        
        public void Discard(int index)
        {
            cards.Remove(cards[index]);
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public Hand()
        {
            
        }
        public Hand(Deck d, int numCards)
        {
            
        }
        public bool HasCard(Card c)
        {
            return IndexOf(c) != -1;
        }


    
        public bool HasCard(int value)
        {
            return value != -1;
        }
        public bool HasCard(int value, int suit)
        {
            if (value != -1 && suit != -1)
                return true;
            else
                return false;
        }
        

        public override string ToString()
        {
            string output = "";
            // go through every card in the deck
            foreach (Card c in cards)
                // ask the card to convert itself to a string
                output += (c.ToString() + "\n");
            return output;
        }
    }
}
