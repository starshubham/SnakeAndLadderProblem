using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem.");

            SnakeAndLadder StartPlay = new SnakeAndLadder();
            StartPlay.PlayGame();
        }
    }
}
