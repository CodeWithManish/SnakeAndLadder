using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder problem statement");
            Console.ReadLine();

            SnakeAndLadderGame player1 = new SnakeAndLadderGame();
            SnakeAndLadderGame player2 = new SnakeAndLadderGame();

            int i = 0;
            bool flag = true;

            while (flag)
            {
                int position1 = 0, position2 = 0;

                if (i % 2 == 0)
                {

                    position1 = player1.Play();
                }
                else
                {
                    position2 = player2.Play();
                }

                if (position1 == 100)
                {
                    Console.WriteLine("Player1 won the game! \n");
                    flag = false;
                }
                if (position2 == 100)
                {
                    Console.WriteLine("Player2 won the game! \n");
                    flag = false;
                }
                i++;
            }
        }

    }
}

