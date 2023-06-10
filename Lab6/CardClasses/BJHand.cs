using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;
using CardClasses;

namespace Lab6
{
    public class BJHand : Hand
    {
        public BJHand() : base() { }
        public BJHand(Deck d, int numCards) : base(d, numCards) { } 

        public bool HasAce
        {
            get
            {
                return HasCard(1);
            }
        }
        public int Score
        {
            get
            {
                int score = 0;
                foreach(Card c in cards)
                {
                    if (c.IsFaceCard())
                        score += 10;
                    else
                        score += c.Value;
                }
                return score;
            }
        }
        public bool IsBusted(int score)
        {
            bool isBusted = false;
            if (score > 21)
                isBusted = true;
            else
                isBusted = false;
            return isBusted;


        }

    }
}
