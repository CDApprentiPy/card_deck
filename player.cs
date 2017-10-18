using System;
using System.Collections.Generic;

namespace card_deck{
    public class Player
    {
        public string name;
        private List<Card> hand;

        public Player(string n)
        {
            hand = new List<Card>();
            name = n;
        }
        public Card Draw(Deck deck)
        {
            Card c = deck.Deal();
            hand.Add(c);
            return c;
        }
        public Card Discard(int i)
        {
            Card c = hand[i];
            if(c != null)
            {
                hand.RemoveAt(i);
            }
            return c;      
        }
    }   
}