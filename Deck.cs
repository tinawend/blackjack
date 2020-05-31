using System;
using System.Collections.Generic;

namespace examination_3
{
    public class Deck
    {

            public List<Card> Cards;

    public Deck()
    {

    }
    public List<Card> DeckOfCards(){
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
        // Console.WriteLine(Cards.Count);
        // Console.WriteLine(Cards);
        return Cards;

        // foreach(Card card in Cards)
        // {
        // return card;
        // }
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
        int n = Cards.Count;  
        while (n > 1) { 
        n--;  
        int k = rng.Next(n + 1);  
        Card value = Cards[k];  
        Cards[k] = Cards[n];  
        Cards[n] = value;
        }
// Console.WriteLine(string.Join("\n", Cards));
// Console.WriteLine(Cards.Count);
return Cards[0];
// Console.WriteLine((int)Cards[0].Rank);

    }
        
    }
}