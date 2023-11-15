
using System;

namespace TicTacToe
{
    internal class Game
    {
        char[,] grid = new char[3, 3];
        public Game()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    grid[x, y] = '.';
                }
            }
        }

        public bool Ended()
        {
            // Check for win conditions
            for (int i = 0; i < 3; i++)
            {
                // Check rows and columns
                if ((grid[i, 0] == grid[i, 1] && grid[i, 1] == grid[i, 2] && grid[i, 0] != '.') ||
                    (grid[0, i] == grid[1, i] && grid[1, i] == grid[2, i] && grid[0, i] != '.'))
                {
                    return true; // Win condition met
                }
            }

            // Check diagonals
            if ((grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != '.') ||
                (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != '.'))
            {
                return true; // Win condition met
            }

            // Check for draw condition (no empty cells)
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (grid[x, y] == '.')
                    {
                        return false; // Empty cell found, game continues
                    }
                }
            }

            // If no win and no empty cells, it's a draw
            return true;
        }


        public class BadMoveException : Exception
        {
            public BadMoveException(string message) : base(message) { }
        }


        internal void Move(int position, char player)
        {
            if (position < 0 || position > 8)
                throw new ArgumentException("Position must be in the range 0 to 8.");

            if (grid[position % 3, position / 3] != '.')
                throw new BadMoveException("The selected cell is already occupied.");

            grid[position % 3, position / 3] = player;
        }

        public void Print()
        {
            Console.Clear();

            Console.WriteLine("Key");
            int cell = 0;
            for (int y = 0; y < 3; y++)
            {
                if (y >= 1) Console.WriteLine("---+---+---");
                for (int x = 0; x < 3; x++)
                {
                    if (x >= 1) Console.Write("|");
                    Console.Write(" {0} ", cell++);
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            for (int y = 0; y < 3; y++)
            {
                if (y >= 1) Console.WriteLine("---+---+---");
                for (int x = 0; x < 3; x++)
                {
                    if (x >= 1) Console.Write("|");
                    Console.Write(" {0} ", grid[x, y]);
                }
                Console.WriteLine();
            }

        }

    }
}
