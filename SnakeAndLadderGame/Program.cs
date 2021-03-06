using System;

namespace SnakeAndLadderGame
{
    
    class Program
    {
        // From UC4
        //Constants 
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome To Snake and Ladder Game***");

            /* UC1:- Snake and Ladder game played with single player at start position 0 */
            //int playerPosition = 0;
            //Console.WriteLine("Player Position: " + playerPosition);

            /* UC2:- The Player rolls the die to get a number between 1 to 6. 
             * - Use ((RANDOM)) to get the number between */

            //RollDice roll = new RollDice();   //Creating an object of RollDice class.           
            //int playerDice = roll.rollDice();  // Calling Method of RollDice class.
            //Console.WriteLine("Roll Dice: " + playerDice);

            //UC3
            //RollDice roll = new RollDice();   //Creating an object of RollDice class.   
            //int playerDice = roll.rollDice();
            //int option = roll.checkOption();
            //switch (option)
            //{
            //    case 1:
            //        Console.WriteLine("Player Got Ladder.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Player got Snake.");
            //        break;
            //    default:
            //        Console.WriteLine("Player not playing.");
            //        break;
            //}

            /* UC4:- Repeat till the Player reaches the winning position 100. 
               - Note In case the player position moves below 0, then the player restarts from 0
             */

            //Console.WriteLine("Single Player mode: Starting position 0");
            //Console.WriteLine("GAME START");
            //Console.WriteLine();

            ////Variables
            //int position = 0;

            ////creatting random object
            //Random die = new Random();
            //Random options = new Random();

            //while (position <= FINAL)
            //{
            //    int dice = die.Next(1, 7);
            //    Console.WriteLine("The number on this die roll is: " + dice);
            //    int opt = options.Next(0, 3);

            //    if (opt == NO_PLAY)
            //    {
            //        Console.WriteLine("No play: Player in same position-- " + position);
            //    }
            //    else if (opt == LADDER)
            //    {
            //        position = position + dice;
            //        Console.WriteLine("Ladder!!! new postion-- " + position);
            //    }
            //    else
            //    {
            //        position = position - dice;
            //        Console.WriteLine("Snake!!! new position-- " + position);
            //    }

            //    if (position < 0)
            //    {
            //        position = 0;
            //    }
            //}


            /* UC5:- Ensure the player gets to exact winning position 100. 
                     - Note in case the player position go above 100, the player stays in the same previous 
                       position till the player gets the exact number that adds to 100
             */
            //Console.WriteLine("Single Player mode: Starting position 0");
            //Console.WriteLine("GAME START");
            //Console.WriteLine();

            ////Variables
            //int position = 0;

            ////creatting random object
            //Random die = new Random();
            //Random options = new Random();

            //while (position < FINAL)
            //{
            //    int dice = die.Next(1, 7);
            //    Console.WriteLine("The number on this die roll is: " + dice);
            //    int opt = options.Next(0, 3);

            //    if (opt == NO_PLAY)
            //    {
            //        Console.WriteLine("No play: Player in same position-- " + position);
            //    }
            //    else if (opt == LADDER)
            //    {
            //        position = position + dice;
            //        if (position > 100)
            //        {
            //            Console.WriteLine("Try Again, throw exceeded 100!");
            //            position = position - dice;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ladder!!! new postion " + position);
            //        }

            //    }
            //    else
            //    {
            //        position = position - dice;
            //        Console.WriteLine("Snake!!! new position-- " + position);
            //    }

            //    if (position < 0)
            //    {
            //        position = 0;
            //    }
            //}


            /* UC6:- Report the number of times the dice was played to win the game
                     and also the position after every die role
             */
            //Console.WriteLine("Single Player mode: Starting position 0");
            //Console.WriteLine("GAME START");
            //Console.WriteLine();

            ////Variables
            //int position = 0;
            //int count = 0;

            ////creatting random object
            //Random die = new Random();
            //Random options = new Random();

            //while (position < FINAL)
            //{
            //    int dice = die.Next(1, 7);
            //    Console.WriteLine("The number on this die roll is: " + dice);
            //    int opt = options.Next(0, 3);

            //    if (opt == NO_PLAY)
            //    {
            //        Console.WriteLine("No play: Player in same position-- " + position);
            //    }
            //    else if (opt == LADDER)
            //    {
            //        position = position + dice;
            //        if (position > 100)
            //        {
            //            Console.WriteLine("Try Again, throw exceeded 100!");
            //            position = position - dice;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ladder!!! new postion " + position);
            //        }

            //    }
            //    else
            //    {
            //        position = position - dice;
            //        Console.WriteLine("Snake!!! new position-- " + position);
            //    }

            //    if (position < 0)
            //    {
            //        position = 0;
            //    }
            //    Console.WriteLine("The position after the {0} die roll is {1} ", count, position);
            //    count++;
            //}
            //Console.WriteLine("The number of times the die thrown is: " + count);


            /* UC7:- Play the game with 2 Player. In this case if a Player gets a Ladder then plays again.
                     Finally report which Player won the game
             */
            int playerOnePosition = 0, playerTwoPosition = 0, winPosition = 100, countRound = 0;
            RollDice roll = new RollDice();   //Creating an object of RollDice class. 

            while (playerOnePosition != 100 && playerTwoPosition != 100)
            {
                int playerOneDice = roll.rollDice();
                int playerTwoDice = roll.rollDice();
                int option = roll.checkOption();
                countRound++;
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Player Got Ladder.");
                        playerOnePosition += playerOneDice;
                        playerTwoPosition += playerTwoDice;
                        int OneChance = roll.rollDice();
                        playerOnePosition += playerOneDice; //If got ladder Rolling again
                        int TwoChance = roll.rollDice();
                        playerTwoPosition += playerTwoDice; //If got ladder Rolling again
                        if (playerOnePosition > winPosition)
                        {
                            playerOnePosition -= playerOneDice;
                        }
                        else if (playerTwoPosition > winPosition)
                        {
                            playerTwoPosition -= playerTwoDice;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Player got Snake.");
                        if ((playerOnePosition - playerOneDice) < 0)
                        {
                            playerOnePosition = 0;

                        }
                        else if ((playerTwoPosition - playerTwoDice) < 0)
                        {
                            playerTwoPosition = 0;
                        }
                        else
                        {
                            playerOnePosition -= playerOneDice;
                            playerTwoPosition -= playerTwoDice;
                        }
                        break;
                    default:
                        Console.WriteLine("Player not playing.");
                        break;
                }
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :Player_One_Position: {playerOnePosition}");
                Console.WriteLine($"Roll_Dice_Count:{ countRound } :Player_Two_Position: {playerTwoPosition}");
                if (playerOnePosition == winPosition || playerTwoPosition == winPosition)
                {
                    if (playerOnePosition == winPosition)
                    {

                        Console.WriteLine("----------Player_One_Won----------");
                        Console.WriteLine("Number of times Player1 dice was played : {0}", countRound);
                    }
                    else if (playerTwoPosition == winPosition)
                    {

                        Console.WriteLine("----------Player_Two_Won----------");
                        Console.WriteLine("Number of times Player2 dice was played : {0}", countRound);
                    }
                }
            }
        }
    }
}
