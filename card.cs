namespace card_deck{
    public class Card
    {
        public string stringVal
        {
            get
            {
                if(val>1 && val<11)
                {
                    return val.ToString();
                }
                else if(val==11)
                {
                    return "Jack";
                }
                else if(val==12)
                {
                    return "Queen";
                }
                else if(val==13)
                {
                    return "King";
                }
                else
                {
                    return "Joker";
                }
            }
        }
        public string suit;
        public int val;

        public Card(string cardSuit, int cardValue)
        {
            suit = cardSuit;
            val = cardValue;
        }
    }
}