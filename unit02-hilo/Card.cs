using System;

namespace unit02_hilo
{
    public class Card
    {
        public int currCard;
        public int nextCard;
        public Card()
        {
            nextCard = -1;
        }

        public int getCard()
        {
            Random rand = new Random();
            int value = rand.Next(1, 13);
            return value;
        }
    }
}
