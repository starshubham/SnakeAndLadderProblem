using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class RollDice
    {
        public int rollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);     //To Get random number between 1 to 6
            return dice;
        }
    }
}
