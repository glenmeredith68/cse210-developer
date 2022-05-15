using System;
using unit02_hilo;

namespace unit02_hilo
{
    public class Director
    {
        Card cards;
        public int currCard;
        public int nextCard;
        public int score;
        public Director()
        {
            cards = new Card();
            currCard = cards.currCard;
            nextCard = cards.nextCard;

            score = 300;
        }


        public void setCards()
        {
            if (nextCard != -1)
            {
                currCard = nextCard;
                nextCard = cards.getCard();
            }
            else
            {
                currCard = cards.getCard();
                nextCard = cards.getCard();
            }
        }
        public string getInput()
        {
            Console.Write("Will the next card be higher or lower? [h/l]");
            string answer = Console.ReadLine();
            return answer;
        }
        public void takeTurn()
        {
            setCards();
            Console.WriteLine($"The card is {currCard}. ");
            string answer = getInput();
            Console.WriteLine($"The next card is {nextCard}. ");
            if ((answer == "h" && nextCard >= currCard)||(answer == "l" && nextCard < currCard))
            {
                score += 100;
                Console.WriteLine("You were right! +100 points! ");
            }
            else if ((answer == "h" && nextCard < currCard)||(answer == "l" && nextCard >= currCard))
            {
                score -= 75;
                Console.WriteLine("You were wrong. :( -75 points. ");
            }
            Console.WriteLine($"Your score is {score}. ");
        }
    }
}

