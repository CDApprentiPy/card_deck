using System;
using System.Collections.Generic;

namespace card_deck{
    public class Deck
    {
        private List<Card> cards;
        public Deck()
        {
            Reset();
            Shuffle();
        }
        public void Reset()
        {
            cards = new List<Card>();
            string [] suits = new string[4]{
                "Hearts", "Clubs", "Spades", "Diamonds"
            };
            foreach(string suit in suits)
            {
                for(int val = 1; val <= 13; val++)
                {
                    cards.Add(new Card(suit, val));
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < cards.Count ; i++)
            {
                int randI = rand.Next(i);
                Card temp = cards[randI];
                cards[randI] = cards[i];
                cards[i] = temp;
            }
        }
        public Card Deal()
        {
            if(cards.Count > 0)
            {
                Card top = cards[0];
                cards.RemoveAt(0);
                return top;
            }
            else
            {
                return null;
            }
        }
    }
}