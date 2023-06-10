using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int value;
        private int suit;

        public Card()
        {
            value = generator.Next(1, 14);
            suit = generator.Next(1, 5);
        }
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public int Suit
        {
            get { return suit; }
            set { this.suit = value; }

        }

        public bool IsRed()
        {
            return !IsBlack();
        }
        public bool IsBlack()
        {
            if (IsSpade() || IsClub())
                return true;
            else
                return false;

        }

        public bool IsFaceCard()
        {
            switch (value)
            {
                case 11:
                case 12:
                case 13:
                    return true;
                default: return true;
            }
        }
        public bool IsAce()
        {
            if (value == 1)
                return true;
            else
                return false;
        }
        public bool IsClub()
        {
            if (suit == 1)
                return true;
            else
                return false;
        }
        public bool IsDiamond()
        {
            if (suit == 2)
                return true;
            else
                return false;
        }
        public bool IsHeart()
        {
            if (suit == 3)
                return true;
            else
                return false;

        }
        public bool IsSpade()
        {
            if (suit == 4)
                return true;
            else
                return false;

        }
        public bool HasMatchingSuit(Card other)
        {
            if (other.suit == value)
                return true;
            else
                return false;
        }
        public bool HasMatchingValue(Card other)
        {
            if (other.Value == value)
                return true;
            else
                return false;
        }
        static void TestCardConstructors()
        {
            Card c1 = new Card();
            Card c2 = new Card(1, 5);
            Console.WriteLine("This is a test, boom cards" + c1.value);
            Console.WriteLine("This is another test, boom... suit!" + c1.suit);
        }
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
    }
}
