// BattleshipRefactor -- A refactoring of BattleshipSimple
using System;

namespace BattleshipSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grid size (e.g. 5 for 5x5): ");
            int size = int.Parse(Console.ReadLine());

            var game = new BattleShipGame(size);
            ConsoleKeyInfo response;
            do
            {
                game.Reset();
                game.Play();

                Console.WriteLine("Do you want to play again (y/n)");
                response = Console.ReadKey();

            } while (response.Key == ConsoleKey.Y);
        }
    }
}
