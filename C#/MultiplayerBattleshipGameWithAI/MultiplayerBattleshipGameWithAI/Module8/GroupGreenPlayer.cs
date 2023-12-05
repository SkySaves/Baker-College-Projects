
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

        public GroupGreenPlayer(string name)
        {
            Name = name;
            _random = new Random();
            // Initialize the _occupiedPositions array with a default size.
            // This size should be the maximum possible grid size you expect.
            _occupiedPositions = new bool[10, 10]; // Example size, adjust as needed
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
            // Ensure the attack position is within the grid bounds
            int xPosition = _random.Next(_gridSize); // X-coordinate within grid size
            int yPosition = _random.Next(_gridSize); // Y-coordinate within grid size

            return new Position(xPosition, yPosition);
        }

        public void SetAttackResults(List<AttackResult> results)
        {
            // Update AI's state based on the results of all players' attacks.
        }
    }
}
