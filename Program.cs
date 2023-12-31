﻿using System;
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
                if (!gameData.IsCutscene && !gameData.IsEncounter) Renderer.Render(gameData, currentMap);
                if (gameData.IsCutscene && !gameData.IsEncounter)
                {
                    switch (gameData.CutsceneNumber)
                    {
                        case -1:
                            Cutscene.PokemonPrologue(gameData);
                            break;
                        case 0:
                            Cutscene.EntryDialog(gameData);
                            break;
                        case 5:
                            Cutscene.Enemy2Defeat(gameData);
                            break;
                        case 6:
                            Cutscene.Enemy2(gameData);
                            break;
                        case 7:
                            Cutscene.Enemy1Defeat(gameData);
                            break;
                        case 8:
                            Cutscene.Enemy1(gameData);
                            break;
                        case 9:
                            Cutscene.NurseJoy(gameData);
                            break;
                    }
                }
                if (!gameData.IsEncounter) Controls.KeyboardEvent(gameData, currentMap);

                if (!gameData.IsCutscene && gameData.IsEncounter) Battle.StartBattle(gameData);

            }
        }
    }
}