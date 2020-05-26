using System;
using System.Collections.Generic;

namespace examination_3
{
    public class Deck
    {

            public List<Card> Cards;

    public Deck()
    {
        Cards = new List<Card>();
        int numSuits = Enum.GetNames(typeof(CardSuit)).Length;
        int numKinds = Enum.GetNames(typeof(CardRank)).Length;

        for (int suit = 0; suit < numSuits; suit++)
        {
            for (int rank = 2; rank <= numKinds + 1; rank++)
            {
                Cards.Add(new Card((CardSuit)suit, (CardRank)rank));
            }
        }
        foreach(Card card in Cards)
        {
        Console.WriteLine(card.ToString());
        }
    }
        // public Deck(Enumerable<Card> collection) : base(collection)
        // {
        //         // string [] value = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        //         // string [] suit = {"Hearts ♥︎", "Spades ♠︎", "Clubs ♣︎", "Dimonds ♦︎"};
        // }
        // public Card(): base(52) {

        // }
        
    }
}