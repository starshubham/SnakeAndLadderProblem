using System;

namespace SnakeAndLadderGame
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder Gmae***");

            /* UC1:- Snake and Ladder game played with single player at start position 0 */
            //int playerPosition = 0;
            //Console.WriteLine("Player Position: " + playerPosition);

            /* UC2:- The Player rolls the die to get a number between 1 to 6. 
             * - Use ((RANDOM)) to get the number between */

            //RollDice roll = new RollDice();   //Creating an object of RollDice class.           
            //int playerDice = roll.rollDice();  // Calling Method of RollDice class.
            //Console.WriteLine("Roll Dice: " + playerDice);

            //UC3
            RollDice roll = new RollDice();   //Creating an object of RollDice class.   
            int playerDice = roll.rollDice();
            int option = roll.checkOption();
            switch (option)
            {
                case 1:
                    Console.WriteLine("Player Got Ladder.");
                    break;
                case 2:
                    Console.WriteLine("Player got Snake.");
                    break;
                default:
                    Console.WriteLine("Player not playing.");
                    break;
            }
        }
    }
}
