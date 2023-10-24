
using System;

namespace BattleshipSimple
{
    class Program
    {

        private static readonly char[,] Grid = new char[,]
        {
            {'.', '.', '.', '.', 'S', 'S', 'S', '.', '.', '.'},
            {'P', 'P', '.', '.', '.', '.', '.', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', 'P'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', 'P'},
            {'.', '.', 'A', 'A', 'A', 'A', 'A', '.', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', 'P', 'P'},
            {'.', 'S', '.', '.', '.', '.', '.', 'B', '.', '.'},
            {'.', '.', '.', '.', '.', '.', '.', '.', '.', '.'},
        };
        static void Main(string[] args)
        {
            while (true)
            {
                // Step 3: Add horizontal labels
                Console.Write("    ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("  " + i + " ");
                }
                Console.WriteLine();

                // Step 1: Improve the rendering of each grid square
                for (int i = 0; i < 10; i++)
                {
                    // Draw the top border of each cell
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("#---");
                    }
                    Console.WriteLine("#");

                    // Step 3: Add vertical labels (Moved here to align with rows)
                    Console.Write(" " + (char)(65 + i) + " ");

                    // Draw the content and side borders of each cell
                    for (int j = 0; j < 10; j++)
                    {
                        Console.Write("| ");

                        // Step 2: Different colors for different ship types
                        if (Grid[i, j] == 'S')
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (Grid[i, j] == 'P')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (Grid[i, j] == 'A')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (Grid[i, j] == 'B')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(Grid[i, j]);
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                    Console.WriteLine("|");
                }

                // Draw the bottom border of the last row
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("#---");
                }
                Console.WriteLine("#");

                // Capture the guess
                Console.WriteLine("\nEnter your guess:");
                var guess = Console.ReadLine();

                // Step 4: Parse the input
                var letter = guess.Substring(0, 1).ToUpper();
                var number = guess.Substring(1);
                if (Int32.TryParse(number, out int num) && letter.Length == 1 && letter[0] >= 'A' && letter[0] <= 'J')
                {
                    // Valid input
                    int row = letter[0] - 'A';
                    int col = num - 1;
                    // Mark the grid location as used (for now, let's use 'X')
                    Grid[row, col] = 'X';
                }
                else
                {
                    // Invalid input
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
                }
            }
        }
    }
}