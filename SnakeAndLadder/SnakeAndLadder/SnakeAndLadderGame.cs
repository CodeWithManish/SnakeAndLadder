using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadderGame
    {
        int playerPosition = 0; int counter = 0;

        Random random = new Random();
        public int DiceRoll()
        {
            int dice = random.Next(1, 7);
            counter++;
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
                        if (playerPosition + diceoutcome <= WINNING_POSITION)
                            playerPosition += diceoutcome;
                        break;

                    case SNAKE:
                        if (playerPosition - diceoutcome > NOPLAY)
                            playerPosition -= diceoutcome;
                        else
                            playerPosition = NOPLAY;

                        break;

                    case NOPLAY:
                        break;
                }
                Console.WriteLine("player position are:{0}", playerPosition);
            }
            Console.WriteLine("the total number of time the Dice was played {0}", counter);

        }
    }
}