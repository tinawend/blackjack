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

        public void DealUntilDone(Player player)
        {
                player.HitMe(deck.Shuffle());
                deck.removeCardFromDeck();
                do 
                {
                    player.HitMe(deck.Shuffle());
                    deck.removeCardFromDeck();
                }
                while (!player.isDone());
        }

        public void PrintResults(Player player)
        {
                player.PrintName();
                Console.Write(string.Join(", ", player.Hand));
                Console.WriteLine(" (" + player.Score() + ")");
                deck.ThrowUsedCards(player);
        }

        public void StartRound ()
        {
            Random random = new Random();
            for(int i = 0; i < _players; i++)
            {
                Player player = new Player(random.Next(10, 16), "player " + (i+1));
                Dealer dealer = new Dealer(random.Next(10, 16), "Dealer");
                
                DealUntilDone(player);
                PrintResults(player);

                if (player.Score() == 21) 
                {
                    Console.WriteLine("Player wins!");
                } 
                else if (player.Hand.Count == 5 && player.Score() < 21) 
                {
                    Console.WriteLine("player wins!");
                } 
                else if (player.Score() > 21) 
                {
                    Console.WriteLine("BUSTED!");
                } 
                else if (player.Score() < 21 && player.Hand.Count < 5) 
                {
                    DealUntilDone(dealer);
                    PrintResults(dealer);
                    
                    if (dealer.Score() == 21) 
                    {
                        Console.WriteLine("dealer wins!");
                    } 
                    else if (dealer.Score() > 21) 
                    {
                        Console.WriteLine("player wins!");
                    } 
                    else if (player.Score() > dealer.Score()) 
                    {
                        Console.WriteLine("player wins!");
                    } 
                    else if (player.Score() < dealer.Score()) 
                    {
                        Console.WriteLine("dealer wins!");
                    } 
                    else if (player.Score() == dealer.Score()) 
                    {
                        Console.WriteLine("dealer wins!");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}