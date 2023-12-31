﻿
using System;
using System.Collections.Generic;
using System.Linq;
using CS3110_Module_8_GroupGreen;

namespace CS3110_Module_8_GroupGreen
{
    public class GroupGreenPlayer : IPlayer
    {
        public int Index { get; private set; }
        public string Name { get; private set; }
        private readonly Random _random;
        private int _gridSize;
        private bool[,] _occupiedPositions;
        private List<Position> _potentialTargets = new List<Position>();
        private bool _isTargetingShip = false;
        private Position _lastHitPosition;
        private List<Position> _unguessedPositions;

        public GroupGreenPlayer(string name)
        {
            Name = name;
            _random = new Random();
            // Initialize the _occupiedPositions array with a default size.
            // This size should be the maximum possible grid size expected
            _occupiedPositions = new bool[10, 10]; // Example size, adjust as needed
            _unguessedPositions = new List<Position>();
        }

        public void StartNewGame(int playerIndex, int gridSize, Ships ships)
        {
            Index = playerIndex;
            _gridSize = gridSize;
            // Reinitialize the _occupiedPositions array with the actual grid size
            _occupiedPositions = new bool[gridSize, gridSize];

            foreach (var ship in ships._ships)
            {
                bool placed = false;
                while (!placed)
                {
                    Direction direction = _random.Next(2) == 0 ? Direction.Horizontal : Direction.Vertical;
                    int startX, startY;

                    if (direction == Direction.Horizontal)
                    {
                        startX = _random.Next(gridSize - ship.Length); // Ensure ship fits horizontally
                        startY = _random.Next(gridSize);
                    }
                    else
                    {
                        startX = _random.Next(gridSize);
                        startY = _random.Next(gridSize - ship.Length); // Ensure ship fits vertically
                    }

                    if (CanPlaceShip(startX, startY, ship.Length, direction, gridSize))
                    {
                        Position startPosition = new Position(startX, startY);
                        ship.Place(startPosition, direction);
                        MarkOccupiedPositions(startX, startY, ship.Length, direction);
                        placed = true;
                    }
                }
            }
            // Initialize the list of unguessed positions
            _unguessedPositions.Clear();
            for (int x = 0; x < gridSize; x++)
            {
                for (int y = 0; y < gridSize; y++)
                {
                    _unguessedPositions.Add(new Position(x, y));
                }
            }
        }


        private bool CanPlaceShip(int startX, int startY, int length, Direction direction, int gridSize)
        {
            for (int i = 0; i < length; i++)
            {
                int x = startX + (direction == Direction.Horizontal ? i : 0);
                int y = startY + (direction == Direction.Vertical ? i : 0);

                if (x >= gridSize || y >= gridSize || _occupiedPositions[x, y])
                {
                    return false;
                }
            }
            return true;
        }

        private void MarkOccupiedPositions(int startX, int startY, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                int x = startX + (direction == Direction.Horizontal ? i : 0);
                int y = startY + (direction == Direction.Vertical ? i : 0);
                _occupiedPositions[x, y] = true;
            }
        }

        public Position GetAttackPosition()
        {
            //Console.WriteLine($"Debug: {Name} GetAttackPosition called.");

            if (!_isTargetingShip)
            {
                // Randomly select a position that hasn't been guessed yet
                Position guess;
                do
                {
                    guess = new Position(_random.Next(_gridSize), _random.Next(_gridSize));
                    //Console.WriteLine($"Debug: {Name} considering random position {guess.X},{guess.Y}");
                } while (_occupiedPositions[guess.X, guess.Y]);

                Console.WriteLine($"Debug: {Name} guessing position {guess.X},{guess.Y}");
                return guess;
            }
            else
            {
                // Target the neighboring cells of the last hit position
                var neighbors = GetNeighbors(_lastHitPosition);
                foreach (var neighbor in neighbors)
                {
                    //Console.WriteLine($"Debug: {Name} considering neighbor position {neighbor.X},{neighbor.Y}");
                    if (IsValidPosition(neighbor) && !_occupiedPositions[neighbor.X, neighbor.Y])
                    {
                        Console.WriteLine($"Debug: {Name} targeting position {neighbor.X},{neighbor.Y}");
                        return neighbor;
                    }
                }

                if (_unguessedPositions.Count > 0)
                {
                    int index = _random.Next(_unguessedPositions.Count);
                    Position guess = _unguessedPositions[index];
                    _unguessedPositions.RemoveAt(index);
                    //Console.WriteLine($"Debug: {Name} guessing position {guess.X},{guess.Y}");
                    return guess;
                }
                else
                {
                    // Fallback in case all positions have been guessed
                    //Console.WriteLine($"Debug: {Name} has no more positions to guess");
                    return new Position(0, 0); // This should ideally never happen
                }
          
            // If no valid neighbors, revert to random guessing
            _isTargetingShip = false;
                //Console.WriteLine($"Debug: {Name} reverting to random guessing");
                return GetAttackPosition();

            }
        }

        private Position GetRandomGuess()
        {
            Position guess;
            do
            {
                guess = new Position(_random.Next(_gridSize), _random.Next(_gridSize));
            } while (_occupiedPositions[guess.X, guess.Y]);
            return guess;
        }

        public void SetAttackResults(List<AttackResult> results)
        {
            foreach (var result in results)
            {
                if (result.PlayerIndex == Index)
                {
                    _occupiedPositions[result.Position.X, result.Position.Y] = true;
                    if (result.ResultType == AttackResultType.Hit)
                    {
                        _isTargetingShip = true;
                        _lastHitPosition = result.Position;
                    }
                    else if (result.ResultType == AttackResultType.Sank)
                    {
                        _isTargetingShip = false;
                    }
                }
            }
        }

        private List<Position> GetNeighbors(Position position)
        {
            return new List<Position>
            {
                new Position(position.X - 1, position.Y),
                new Position(position.X + 1, position.Y),
                new Position(position.X, position.Y - 1),
                new Position(position.X, position.Y + 1)
            };
        }

        private bool IsValidPosition(Position position)
        {
            return position.X >= 0 && position.X < _gridSize && position.Y >= 0 && position.Y < _gridSize;
        }





    }
}
