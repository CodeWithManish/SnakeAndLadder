using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        int playerPosition = 0;

        Random random = new Random();
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            return dice;
        }
        public void Play()
        {
            const int NOPLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
            int option = random.Next(1, 3);
            int diceoutcome = DiceRoll();

            while (playerPosition < WINNING_POSITION)
            {
                switch (option)
                {
                    case LADDER:
                        playerPosition += diceoutcome;
                        break;

                    case SNAKE:
                        if (playerPosition < NOPLAY)
                            playerPosition -= diceoutcome;
                        else
                            playerPosition = NOPLAY;

                        break;

                    case NOPLAY:
                        break;
                }
            }

        }
    }
}