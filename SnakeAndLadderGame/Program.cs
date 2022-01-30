using System;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Problem.");

            SnakeAndLadder startPlay = new SnakeAndLadder(); // Calling Method
            startPlay.PlayGame();//method PlaGame
        }
    }
}
