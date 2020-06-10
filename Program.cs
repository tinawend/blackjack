using System;
using System.Collections.Generic;

namespace examination_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many players?");
            int players = Convert.ToInt32(Console.ReadLine());
            StartGame startGame = new StartGame(players);
            startGame.StartRound();

        }
    }
}
