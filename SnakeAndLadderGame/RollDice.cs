using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class RollDice
    {
        //UC2
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);     //To Get random number between 1 to 6
            return dice;
        }

        /* UC3:- The Player then checks for a Option. They are No Play, Ladder or Snake. 
               - Use ((RANDOM)) to check for Options - In Case of No Play the player stays in the same position
               - In Case of Ladder the player moves ahead by the number of position received in the die
               - In Case of Snake the player moves behind by the
        */
        public int checkOption()
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            return option;
        }
    }
}
