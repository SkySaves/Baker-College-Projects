// Multiplayer Battleship Game with AI - Partial Solution

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using CS3110_Module_8_GroupGreen;

namespace CS3110_Module_8_GroupGreen
{
    internal class MultiPlayerBattleShip
    {
        const int GridSize = 10-2; // Your player should work when GridSize >=8

        private static readonly Random Random = new Random();
        private readonly List<IPlayer> _players;
        private List<Grid> _playerGrids;
        private List<Ships> _playerShips;
        private List<IPlayer> currentPlayers;

        public MultiPlayerBattleShip(List<IPlayer> players)
        {
            this._players = players;
        }

        internal void Play(PlayMode playMode)
        {
            int loopCounter = 0;
            const int maxLoops = 1000; // Arbitrary large number



            currentPlayers = new List<IPlayer>();
            var availablePlayers = new List<IPlayer>(_players);
            _playerGrids = new List<Grid>();
            _playerShips = new List<Ships>();

            // Add each player in a random order
            for (int i = 0; i < _players.Count; i++)
            {
                var player = availablePlayers[Random.Next(availablePlayers.Count)];
                availablePlayers.Remove(player);
                currentPlayers.Add(player);
            }

            // Tell each player the game is about to start
            for (int i = 0; i < currentPlayers.Count; i++)
            {
                var ships = new Ships();
                ships.Add(new AircraftCarrier());
                ships.Add(new Submarine());
                ships.Add(new Destroyer());
                ships.Add(new Destroyer());
                ships.Add(new PatrolBoat());
                ships.Add(new PatrolBoat());
                ships.Add(new PatrolBoat());
                ships.Add(new Battleship());

                var count = ships._ships.Count();
                int totalLength = ships._ships.Sum(ship => ship.Length);

                currentPlayers[i].StartNewGame(i, GridSize, ships);

                // Make sure player didn't change ships
                if (count != ships._ships.Count()
                    || totalLength != ships._ships.Sum(ship => ship.Length))
                {
                    throw new Exception("Ship collection has ships added or removed");
                }

                var grid = new Grid(GridSize);
                grid.Add(ships);
                _playerGrids.Add(grid);
                _playerShips.Add(ships);
            }

            int currentPlayerIndex = 0;
            while (currentPlayers.Count > 1)
            {
                loopCounter++;
                if (loopCounter > maxLoops)
                {
                    //Console.WriteLine("Debug: Exiting due to potential infinite loop.");
                    break;
                }

                var currentPlayer = currentPlayers[currentPlayerIndex];
                Position pos = currentPlayer.GetAttackPosition();
                var results = CheckAttack(pos);

                // Notify each player of the results
                foreach (var player in currentPlayers)
                {
                    player.SetAttackResults(results);
                }

                DrawGrids();
                Console.WriteLine("\nPlayer " + currentPlayer.Index + "[" + currentPlayer.Name + "]  turn.");
                Console.WriteLine("    Attack: " + pos.X + "," + pos.Y);
                Console.WriteLine("\nResults:");
                foreach (var result in results)
                {
                    Console.Write("    Player " + result.PlayerIndex + " " + result.ResultType);
                    if (result.ResultType == AttackResultType.Sank)
                    {
                        Console.Write(" - " + result.SunkShip);
                    }
                    Console.WriteLine();
                }

                // Remove any ships with sunken battleships
                bool playerRemoved = false;
                for (int i = currentPlayers.Count - 1; i >= 0; --i)
                {
                    var player = currentPlayers[i];
                    if (_playerShips[player.Index].SunkMyBattleShip)
                    {
                        //Console.WriteLine($"Debug: Player {player.Name} battleship sunk. Preparing to remove.");
                        currentPlayers.Remove(player);
                        //Console.WriteLine($"Debug: Player {player.Name} removed. Players left: {currentPlayers.Count}");
                        playerRemoved = true;
                        if (i <= currentPlayerIndex && currentPlayerIndex > 0)
                        {
                            currentPlayerIndex--; // Adjust the index if necessary
                        }
                    }
                }

                //Console.WriteLine($"Debug: Checking for one player left. Players left: {currentPlayers.Count}");
                if (currentPlayers.Count == 1)
                {
                    Console.WriteLine("Only one player left, ending game.");
                    break;
                }

                if (!playerRemoved)
                {
                    // Move to next player
                    //Console.WriteLine($"Debug: No player removed. Moving to next player. Current player index: {currentPlayerIndex}");
                    currentPlayerIndex = (currentPlayerIndex + 1) % currentPlayers.Count;
                }
                else
                {
                    //Console.WriteLine($"Debug: Player removed. Current player index remains: {currentPlayerIndex}");
                }

                if (playMode == PlayMode.Pause)
                {
                    Console.WriteLine("\nPress a key to continue");
                    Console.ReadKey(true);
                }
                else if (playMode == PlayMode.Delay)
                {
                    Thread.Sleep(2000);
                }
                else if (playMode == PlayMode.NoDelay)
                {
                    // Don't delay or pause
                }
            }

            Console.WriteLine();
            Console.WriteLine("Winner is '" + currentPlayers[0].Name + "'");
            Console.WriteLine();

            ConsoleKeyInfo cki;
            Console.WriteLine("\nPress period to continue");
            do
            {
                cki = Console.ReadKey(true);
                //Console.WriteLine("Debug: Key pressed to continue.");

            } while (cki.Key != ConsoleKey.OemPeriod);

        }

        private List<AttackResult> CheckAttack(Position pos)
        {
            var results = new List<AttackResult>();

            foreach (var player in currentPlayers)
            {
                var result = _playerShips[player.Index].Attack(pos);

                // Mark attacks on the grid
                foreach (var grid in _playerGrids)
                {
                    grid.Attack(pos);
                }

                result.PlayerIndex = player.Index;
                results.Add(result);
            }
            return results;
        }

        private void DrawGrids()
        {
            Console.Clear();
            int drawX = 0;
            int drawY = 0;

            for (int i = 0; i < currentPlayers.Count; i++)
            {
                var player = currentPlayers[i];
                var playerIndex = player.Index;

                var grid = _playerGrids[playerIndex];
                Console.SetCursorPosition(drawX, drawY);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;

                Console.Write(player.Name);
                grid.Draw(drawX, drawY + 1);

                drawX += GridSize + 4;
                if (drawX + GridSize > Console.BufferWidth)
                {
                    drawY += GridSize + 5;
                    drawX = 0;
                }
            }
        }
    }
}
