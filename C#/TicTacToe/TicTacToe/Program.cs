
using System;
using static TicTacToe.Game;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            bool playAgain;
            do
            {
                var game = new Game();
                var player = 'X';
                playAgain = false;

                while (!game.Ended())
                {
                    game.Print();
                    bool validMove = false;

                    while (!validMove)
                    {
                        Console.Write("Enter your move: ");
                        string input = Console.ReadLine();
                        int position;

                        if (int.TryParse(input, out position))
                        {
                            try
                            {
                                game.Move(position, player);
                                validMove = true; // Move was successful, exit the loop
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (BadMoveException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Unknown Error occurred.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 0 and 8.");
                        }
                    }

                    // Check if the game has ended after the move
                    if (game.Ended())
                    {
                        game.Print(); // Print the final state of the game
                        break; // Exit the game loop
                    }

                    // Switch players
                    player = (player == 'X') ? 'O' : 'X';
                }

                Console.Write("Play again? (y/n): ");
                var response = Console.ReadLine();
                playAgain = response.Equals("y", StringComparison.OrdinalIgnoreCase);
            } while (playAgain);
        }
    }


}
