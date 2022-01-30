using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    /* UC1:- Snake and Ladder game played with single player at start position 0
     */
    public class SnakeAndLadder
    {
        int START_POSITION = 0;
        public void PlayGame()
        {
            Console.WriteLine(" Single Player Start_Position:- " + START_POSITION);
            Console.ReadLine();
        }
    }
}
