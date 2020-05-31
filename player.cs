using System;
using System.Collections.Generic;

namespace examination_3
{

public class Player
{
    private int _limit;
    private string _name;
    public List<Card> Hand = new List<Card>();
    // Deck deck = new Deck();
     Deck deck = new Deck();
    public Player(int limit, string name)
    {
        _limit = limit;
        _name = name;
         deck.DeckOfCards();

    }
    public int Score(){
        int value = 0;
    for(int i = 0; i < Hand.Count; i++)
    {
        value += (int)Hand[i].Rank;
    }

    for (int i = 0; i < Hand.Count; i++) 
    {
        if ((int)Hand[i].Rank == 14 && value > 21) 
        {
            value -= 13;
        }
    }
            return value;
    }

    public bool isDone () 
    {
        return Score() >= _limit || Hand.Count == 5;
    }

  public void HitMe() {

        Hand.Add(deck.Shuffle());
  }
    public void ReciveCard()
    {
        do 
        {
            HitMe();
        }
            while (!isDone());

        // Console.WriteLine(deck.Shuffle().ToString());
        Console.WriteLine(_name);
        Console.WriteLine(string.Join("\n", Hand));
        Console.WriteLine(Score());
        //  Console.WriteLine(value);
    }



}

}