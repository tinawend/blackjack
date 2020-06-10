using System;
using System.Collections.Generic;

namespace examination_3
{
    public class Deck
    {

        private List<Card> _Cards;
        private List<Card> _Discard = new List<Card>();
        private static Random _rnd = new Random();

        public Deck()
        {

        }

        public List<Card> DeckOfCards()
        {
            _Cards = new List<Card>();
            int numSuits = Enum.GetNames(typeof(CardSuit)).Length;
            int numKinds = Enum.GetNames(typeof(CardRank)).Length;

            for (int suit = 0; suit < numSuits; suit++)
            {
                for (int rank = 2; rank < numKinds + 2; rank++)
                {
                    _Cards.Add(new Card((CardSuit)suit, (CardRank)rank));
                }
            }
            return _Cards;
        }

        // public void printDeck()
        // {
        //     foreach(Card card in Cards)
        //     {
        //     Console.WriteLine(card.ToString());
        //     }
        // }

        public Card Shuffle()
        {
            ReUseOldCards();
            int n = _Cards.Count;  
            while (n > 1) 
            { 
                n--;  
                int k = _rnd.Next(n + 1);  
                Card value = _Cards[k];  
                _Cards[k] = _Cards[n];  
                _Cards[n] = value;
            }

            return _Cards[0];


        }

        public void removeCardFromDeck()
        {
            _Cards.RemoveAt(0);
        }

        public void ThrowUsedCards (Player player) 
        {

            for(int i = 0; i < player.Hand.Count; i++)
          {
                _Discard.Add(player.Hand[i]);
          }
                // Console.WriteLine("Card deck " + _Cards.Count);
                // Console.WriteLine("discard " + _Discard.Count);
        }

        public void ReUseOldCards()
        {
            if(_Cards.Count <= 1)
            {
                for(int i = 0; i<_Discard.Count; i++)
                _Cards.Add(_Discard[i]);
                _Discard.Clear();
            }

        }
        
    }
}