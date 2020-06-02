using System;
using System.Collections.Generic;

namespace examination_3
{
    public class Deck
    {

        public List<Card> Cards;
        public List<Card> Discard = new List<Card>();

        public Deck()
        {

        }

        public List<Card> DeckOfCards()
        {
            Cards = new List<Card>();
            int numSuits = Enum.GetNames(typeof(CardSuit)).Length;
            int numKinds = Enum.GetNames(typeof(CardRank)).Length;

            for (int suit = 0; suit < numSuits; suit++)
            {
                for (int rank = 2; rank < numKinds + 2; rank++)
                {
                    Cards.Add(new Card((CardSuit)suit, (CardRank)rank));
                }
            }
            return Cards;
        }

        public void printDeck()
        {
            foreach(Card card in Cards)
            {
            Console.WriteLine(card.ToString());
            }
        }

    private static Random rng = new Random();
        public Card Shuffle()
        {
            ReUseOldCards();
            int n = Cards.Count;  
            while (n > 1) 
            { 
                n--;  
                int k = rng.Next(n + 1);  
                Card value = Cards[k];  
                Cards[k] = Cards[n];  
                Cards[n] = value;
            }

            return Cards[0];


        }

        public void removeCardFromDeck()
        {
            Cards.RemoveAt(0);
        }

      public void ThrowUsedCards (Player player) {

            for(int i = 0; i < player.Hand.Count; i++)
          {

    Discard.Add(player.Hand[i]);
          }
    //       Console.WriteLine("Card deck " + Cards.Count);
    // Console.WriteLine("discard " + Discard.Count);
  }

        public void ReUseOldCards()
        {
            if(Cards.Count <= 1)
            {
                for(int i = 0; i<Discard.Count; i++)
                Cards.Add(Discard[i]);
                Discard.Clear();
            }

        }
        
    }
}