using System;
using System.Threading;

namespace Pokemon
{

    class Program
    {
        static void Main()
        {
            GameData gameData = new GameData();
            Map map = new Map();
            Console.CursorVisible = false;

            while (gameData.IsRunning)
            {
                Console.Clear();
                string[] currentMap = map.GetWorldMap(gameData, gameData.Coordinates[0], gameData.Coordinates[1]);
                Renderer.Render(gameData, currentMap);
                if (!gameData.IsFighting && !gameData.IsCutscene) Controls.KeyboardEvent(gameData, currentMap);
            }
        }
    }
}