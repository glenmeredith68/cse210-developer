using System;
using unit02_hilo;
namespace unit02_hilo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;
            Director direct = new Director();
            while (keepPlaying && direct.score > 0) {
                direct.takeTurn();
                Console.Write("You want to keep playing? [y/n] ");
                string answer = Console.ReadLine();
                if (answer == "n") {
                    keepPlaying = false;
                    Console.WriteLine("Thanks for playing, come again! ");
                    return;
                }
            }
            Console.WriteLine("You lose. Try again!");
        }
    }
}
