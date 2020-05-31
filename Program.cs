using System;
using System.Collections.Generic;

namespace examination_3
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Deck deck = new Deck();
        //   deck.DeckOfCards();
        //   Console.WriteLine(deck.Shuffle());
        //  Deck deck = new Deck();
        //  deck.DeckOfCards();
        // Player player = new Player(16, "player");
        // player.ReciveCard();

        // Dealer dealer = new Dealer(10, "Dealer");
        // dealer.ReciveCard();
        StartGame startGame = new StartGame(1);
        startGame.StartRound();

        }
    }
}
