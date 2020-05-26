using System;

namespace examination_3
{

public class Card
{
    public CardSuit Suit { get; private set;}
    public CardRank Rank { get; private set;}

    public Card(CardSuit suit, CardRank rank)
    {
        Suit = suit;
        Rank = rank;
    }

        public override string ToString()
    {
        // Take advantage of how the Enum.ToString() method functions
        return Rank.ToString() + " of " + Suit.ToString();
    }
}

}