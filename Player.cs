using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Player
    {
        public string name;
        public List<Card> hand = new List<Card>();

        public Player(string val)
        {
            this.name = val;
        }

        public void Draw(Deck o)
        {
            hand.Add(o.DealCard());
            Console.WriteLine("******");
            hand.ForEach(Console.WriteLine);
            Console.WriteLine("******");
        }


        public object Discard(int num)
        {
            if(num < hand.Count)
            {
                Card temp = hand[num];
                hand.RemoveAt(num);
                return temp;
            }
            else
            {
                return false;
            }
            
        }
    }
}