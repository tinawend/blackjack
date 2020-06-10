using System;
using System.Collections.Generic;

namespace examination_3
{

    public class Player
    {
        private int _limit;
        private string _name;
        public List<Card> Hand = new List<Card>();

        public Player(int limit, string name)
        {
            _limit = limit;
            _name = name;
        }

        public int Score()
        {
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

        public void HitMe(Card card) 
        {
            Hand.Add(card);
        }

        public void PrintName()
        {
            //_limit
            Console.Write(_name + ": ");
        }



    }

}