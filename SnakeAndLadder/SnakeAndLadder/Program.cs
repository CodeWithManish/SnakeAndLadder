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
            SnakeAndLadderGame player1 = new SnakeAndLadderGame();
            player1.Play();

        }
    }
}
