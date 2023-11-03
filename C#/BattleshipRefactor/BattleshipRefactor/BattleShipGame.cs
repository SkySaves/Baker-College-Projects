// TBD: You must create the Grid class used by this program
// TBD: It needs to be aded to the Project as a file: Grid.cs
using System;

namespace BattleshipSimple
{
    internal class BattleShipGame
    {
        private Grid grid;

        public BattleShipGame(int gridSize)
        {
            grid = new Grid(gridSize);
        }

        internal void Reset()
        {
            grid.Reset();
        }

        internal void Play()
        {
            while (grid.HasShipsLeft)
            {
                grid.Draw();

                Console.WriteLine("Enter coordinates (e.g. A1): ");
                var input = Console.ReadLine();

                // Check if the user wants to quit
                if (input.ToUpper() == "Q")
                {
                    Console.WriteLine("Game exited.");
                    return;
                }

                // Validate the input
                if (IsValidInput(input))
                {
                    int x = input[0] - 'A';
                    int y = int.Parse(input.Substring(1)) - 1;

                    grid.DropBomb(x, y);
                }
                else
                {
                    Console.WriteLine("Please enter a valid location. Drop a bomb at location (e.g., B3) or Q to quit: ");
                }
            }

            // Display the "Congratulations" screen
            DisplayCongratulationsScreen();
        }

        private void DisplayCongratulationsScreen()
        {
            Console.Clear(); // Clear the console
            Console.BackgroundColor = ConsoleColor.DarkMagenta; // Set the background color to purple
            Console.ForegroundColor = ConsoleColor.White; // Set the text color to white
            Console.WriteLine("\n\n");
            Console.WriteLine("Congratulations!! You have sunk all of the ships".PadLeft(50));
            Console.WriteLine("\n\n");
            Console.ResetColor(); // Reset the console colors to default
        }

        private bool IsValidInput(string input)
        {
            if (string.IsNullOrEmpty(input) || input.Length < 2)
                return false;

            char row = input[0];
            string col = input.Substring(1);

            if (!char.IsLetter(row) || !int.TryParse(col, out int colNum))
                return false;

            if (row - 'A' >= grid.Rows || colNum < 1 || colNum > grid.Columns)
                return false;

            return true;
        }
    }
}

