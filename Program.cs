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
            Console.SetWindowSize(60, 100);

            while (gameData.IsRunning)
            {
                Console.Clear();
                string[] currentMap = map.GetWorldMap(gameData, gameData.Coordinates[0], gameData.Coordinates[1]);
                if (!gameData.IsCutscene) Renderer.Render(gameData, currentMap);
                if (gameData.IsCutscene) Cutscene.EntryDialog(gameData);
                Controls.KeyboardEvent(gameData, currentMap);
            }
        }
    }
}