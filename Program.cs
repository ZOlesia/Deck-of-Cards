using System;

namespace deck_of_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck deck1 = new Deck();
            deck1.Shuffle();
            deck1.Reset();

            Player player1 = new Player("Alex");
            Console.WriteLine(player1.name);

            player1.Draw(deck1);
            player1.Draw(deck1);
            player1.Draw(deck1);
            player1.Draw(deck1);

            Console.WriteLine(player1.Discard(5));
            Console.WriteLine(player1.Discard(0));

        }
    }
}
