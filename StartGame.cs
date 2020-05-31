using System;
using System.Collections.Generic;

namespace examination_3
{

    public class StartGame 
    {
        private int _players;
        public StartGame(int players)
        {
            _players = players;

        }
        public void StartRound ()
        {
            for(int i = 0; i < _players; i++)
            {
        Player player = new Player(11, "player "+i);
        player.ReciveCard();
        Dealer dealer = new Dealer(11, "Dealer");
        dealer.ReciveCard();
   if (player.Score() == 21) {
    Console.WriteLine("Player wins");
  } else if (player.Hand.Count == 5 && player.Score() < 21) {
    Console.WriteLine("player wins");
  } else if (player.Score() > 21) {
    Console.WriteLine("player got busted");
  } else if (player.Score() < 21 && player.Hand.Count < 5) {
    // do {
    //   const getCard = this.deck.GetCard()
    //   dealer.HitMe(getCard)
    // } while (!dealer.isDone())
    // console.log(dealer.ToString())

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
            }

        }

        public void Results ()
        {
            

        }

    }
}