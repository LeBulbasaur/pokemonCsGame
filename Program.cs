using System;
using System.Threading;

namespace Pokemon
{

    class Program
    {
        static void Main()
        {
            GameData gameData = new GameData();
            while (gameData.IsRunning)
            {
                string[] worldMap = gameData.Map.GetWorldMap(gameData.Coordinates[0], gameData.Coordinates[1]);
                foreach (string line in worldMap)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine($"x: {gameData.Coordinates[0]} y: {gameData.Coordinates[1]}");
                Controls.KeyboardEvent(gameData, worldMap);

                Console.Clear();
            }
        }
    }
}