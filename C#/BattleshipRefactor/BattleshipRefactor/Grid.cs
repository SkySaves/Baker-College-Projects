using System;

namespace BattleshipSimple
{
    class Grid
    {
        // Define the game board and constants for each ship type and game state
        private char[,] board;
        private const char EMPTY = ' ';
        private const char HIT = 'X';
        private const char BATTLESHIP = 'B';
        private const char PATROL = 'P';
        private const char AIRCRAFT = 'A';
        private const char SUBMARINE = 'S';
        private const char DESTROYER = 'D';

        // Constructor initializes the game board and resets it
        public Grid(int size)
        {
            board = new char[size, size];
            Reset();
        }

        // Property to check if there are any ships left on the board
        public bool HasShipsLeft
        {
            get
            {
                foreach (var cell in board)
                {
                    if (cell == BATTLESHIP || cell == PATROL || cell == AIRCRAFT || cell == SUBMARINE || cell == DESTROYER) return true;
                }
                return false;
            }
        }

        // Reset the board to its initial state and place the ships
        public void Reset()
        {
            // Initialize the board with empty spaces
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = EMPTY;
                }
            }

            // Place each ship on the board
            PlaceShip(BATTLESHIP, 5);
            PlaceShip(AIRCRAFT, 5);
            PlaceShip(PATROL, 2);
            PlaceShip(SUBMARINE, 3);
            PlaceShip(DESTROYER, 3);
        }

        // Place a ship on the board at a random position without overlapping other ships
        private void PlaceShip(char shipType, int shipSize)
        {
            Random rand = new Random();
            bool placed = false;

            // Keep trying to place the ship until a valid position is found
            while (!placed)
            {
                int x = rand.Next(0, board.GetLength(0));
                int y = rand.Next(0, board.GetLength(1));
                bool horizontal = rand.Next(0, 2) == 0;

                // Check if the ship can be placed at the chosen position
                if (CanPlaceShip(x, y, shipSize, horizontal))
                {
                    for (int i = 0; i < shipSize; i++)
                    {
                        if (horizontal)
                        {
                            board[x, y + i] = shipType;
                        }
                        else
                        {
                            board[x + i, y] = shipType;
                        }
                    }
                    placed = true;
                }
            }
        }

        // Check if a ship can be placed at a given position without going out of bounds or overlapping other ships
        private bool CanPlaceShip(int x, int y, int shipSize, bool horizontal)
        {
            for (int i = 0; i < shipSize; i++)
            {
                if (horizontal)
                {
                    if (y + i >= board.GetLength(1) || board[x, y + i] != EMPTY)
                    {
                        return false;
                    }
                }
                else
                {
                    if (x + i >= board.GetLength(0) || board[x + i, y] != EMPTY)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Draw the game board in the console
        public void Draw()
        {
            // Print an empty line for better formatting
            Console.WriteLine(" ");

            // Print spaces for alignment before the column numbers
            Console.Write("   ");

            // Loop to print the column numbers (1, 2, 3, etc.)
            for (int k = 1; k <= board.GetLength(1); k++)
            {
                // Print the column number with spaces for alignment
                Console.Write(k + "   ");
            }
            // Move to the next line after printing all column numbers
            Console.WriteLine();

            // Loop through each row of the board
            for (int i = 0; i < board.GetLength(0); i++)
            {
                // Print the row letter (A, B, C, etc.)
                Console.Write((char)(65 + i) + " ");

                // Loop to print the top border of each cell in the row
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    // Print the top border of the cell
                    Console.Write("#---");
                }
                // Print the rightmost border of the row
                Console.WriteLine("#");

                // Print spaces for alignment before the cell contents
                Console.Write("  ");

                // Loop through each column in the current row
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    // Change the background color based on the ship type or cell state
                    switch (board[i, j])
                    {
                        case BATTLESHIP:
                            Console.BackgroundColor = ConsoleColor.Cyan;
                            break;
                        case PATROL:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            break;
                        case AIRCRAFT:
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.ForegroundColor = ConsoleColor.Black; // Set font color to black for AIRCRAFT
                            break;
                        case SUBMARINE:
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;
                        case DESTROYER:
                            Console.BackgroundColor = ConsoleColor.Green;
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Black; // Default background color for empty cells or hits
                            break;
                    }
                    // Print the cell content with borders
                    Console.Write("| " + board[i, j] + " ");

                    // Reset the background and foreground colors to their defaults
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                // Print the rightmost border of the row after printing all cells
                Console.WriteLine("|");
            }
            Console.Write("  "); //Adds padding towards bottom
            // Loop to print the bottom border of the last row
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write("#---");
            }
            // Print the rightmost border of the bottom row
            Console.WriteLine("#");
        }

        public int Rows
        {
            get { return board.GetLength(0); }
        }

        public int Columns
        {
            get { return board.GetLength(1); }
        }



        // Drop a bomb on the board at the given coordinates
        public void DropBomb(int x, int y)
        {
            if (board[x, y] != EMPTY)
            {
                board[x, y] = HIT;
                Console.WriteLine("Hit!");
            }
            else
            {
                Console.WriteLine("Miss!");
            }
        }
    }
}
