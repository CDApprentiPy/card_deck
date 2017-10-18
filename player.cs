using System;
using System.Collections.Generic;

namespace card_deck{
    public class Player
    {
        public string name;
        public List<Card> hand;

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