using System;
using System.Collections.Generic;

namespace deck_of_cards
{
    public class Deck
    {
        public Card[] deck;
        public int currentCard;
        public const int totalCards = 52;
        // public Random randNum;

        public Deck()
        {
            string[] faces = {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            deck = new Card[totalCards];
            currentCard = 0;
            int count = 0;
            for(int i = 0; i < faces.Length; i++)
            {
                for(int j = 0; j < suits.Length; j++)
                {
                    deck[count] = new Card(faces[i], suits[j]);
                    count++;
                }
            }
        }


        public void Shuffle()
        {
            Random randNum2 = new Random();
            for (int i = 0; i < deck.Length; i++)
            {
                int random = randNum2.Next(0, 52);
                Card temp = deck[i];
                Card temptwo = deck[random];
                deck[i] = deck[random];
                deck[random] = temp;
                Console.WriteLine(deck[i]);
            }
        }


        public Card DealCard()
        {
            if(currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }


        public Deck Reset()
        {
            return new Deck();
        }

    }
}





