using System;
using System.Collections.Generic;

namespace examination_3
{

    public class StartGame 
    {
          Deck deck = new Deck();
        private int _players;
        public StartGame(int players)
        {
            _players = players;
              deck.DeckOfCards();

        }
        public void StartRound ()
        {
            for(int i = 0; i < _players; i++)
            {
        Player player = new Player(11, "player "+i);
        Dealer dealer = new Dealer(11, "Dealer");

       do 
        {
            player.HitMe(deck.Shuffle());
            deck.removeCardFromDeck();
        }
            while (!player.isDone());

        player.PrintName();
        Console.WriteLine(string.Join("\n", player.Hand));
        Console.WriteLine(player.Score());
        deck.ThrowUsedCards(player);

   if (player.Score() == 21) {
    Console.WriteLine("Player wins");
  } else if (player.Hand.Count == 5 && player.Score() < 21) {
    Console.WriteLine("player wins");
  } else if (player.Score() > 21) {
    Console.WriteLine("player got busted");
  } else if (player.Score() < 21 && player.Hand.Count < 5) {

            do 
        {
            dealer.HitMe(deck.Shuffle());
            deck.removeCardFromDeck();
        }
            while (!dealer.isDone());

        // Console.WriteLine(deck.Shuffle().ToString());
        // Console.WriteLine(player._name);
        dealer.PrintName();
        Console.WriteLine(string.Join("\n", dealer.Hand));
        Console.WriteLine(dealer.Score());
        deck.ThrowUsedCards(dealer);
    if (dealer.Score() == 21) {
      Console.WriteLine("dealer wins");
    } else if (dealer.Score() > 21) {
      Console.WriteLine("player wins");
    } else if (player.Score() > dealer.Score()) {
      Console.WriteLine("player wins");
    } else if (player.Score() < dealer.Score()) {
      Console.WriteLine("dealer wins");
    } else if (player.Score() == dealer.Score()) {
      Console.WriteLine("dealer wins");
    }
  }
        Console.WriteLine("\n");
            }

        }

    }
}