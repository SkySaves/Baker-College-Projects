// Multiplayer Battleship Game with AI - Partial Solution

using System.Collections.Generic;
using CS3110_Module_8_GroupGreen;

namespace CS3110_Module_8_GroupGreen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPlayer> players = new List<IPlayer>();
            // Add other players
            players.Add(new DumbPlayer("Dumb 1"));
            players.Add(new RandomPlayer("Random 1"));
            // Add Group Green AI player
            players.Add(new GroupGreenPlayer("Group Green AI"));

            MultiPlayerBattleShip game = new MultiPlayerBattleShip(players);
            game.Play(PlayMode.Pause);  // Play the game with this "play mode"
        }
    }
}

