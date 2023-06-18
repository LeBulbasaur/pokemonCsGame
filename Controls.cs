namespace Pokemon
{
    class Controls
    {
        public static void KeyboardEvent(GameData gameData, string[] map)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (!gameData.IsCutscene && !gameData.IsEncounter)
            {
                int x = gameData.Coordinates[0];
                int y = gameData.Coordinates[1];

                switch (keyInfo.Key)
                {

                    // ARROW UP
                    case ConsoleKey.UpArrow:
                        if (
                            !gameData.IsCutscene
                            && map[y - 1][x] != '('
                            && map[y - 1][x] != ')'
                            && map[y - 1][x] != '|'
                            && map[y - 1][x] != '/'
                            && map[y - 1][x] != '\\'
                            && map[y - 1][x] != '-'
                            && map[y - 1][x] != '_'
                            )
                        {
                            gameData.Coordinates[1]--;
                        }
                        if (map[y - 1][x] == '0')
                        {
                            gameData.Coordinates[1] = 11;
                            gameData.World = 0;
                        }
                        if (map[y - 1][x] == '9')
                        {
                            gameData.Coordinates[0] = 23;
                            gameData.Coordinates[1] = 7;
                            gameData.World = 2;
                        }
                        break;

                    // ARROW DOWN    
                    case ConsoleKey.DownArrow:
                        if (
                            !gameData.IsCutscene
                            && map[y + 1][x] != '('
                            && map[y + 1][x] != ')'
                            && map[y + 1][x] != '|'
                            && map[y + 1][x] != '/'
                            && map[y + 1][x] != '\\'
                            && map[y + 1][x] != '-'
                            && map[y + 1][x] != '_'
                            )
                        {
                            gameData.Coordinates[1]++;
                        }
                        if (map[y + 1][x] == '1')
                        {
                            gameData.Coordinates[1] = 1;
                            gameData.World = 1;
                        }
                        if (map[y + 1][x] == '9')
                        {
                            gameData.Coordinates[0] = 28;
                            gameData.Coordinates[1] = 7;
                            gameData.World = 0;
                        }
                        break;

                    // ARROW LEFT
                    case ConsoleKey.LeftArrow:
                        if (
                            !gameData.IsCutscene
                            && map[y][x - 1] != '('
                            && map[y][x - 1] != ')'
                            && map[y][x - 1] != '|'
                            && map[y][x - 1] != '/'
                            && map[y][x - 1] != '\\'
                            && map[y][x - 1] != '-'
                            && map[y][x - 1] != '_'
                            && map[y][x - 1] != '♞'
                            )
                        {
                            gameData.Coordinates[0]--;
                        }
                        break;

                    // ARROW RIGHT
                    case ConsoleKey.RightArrow:
                        if (
                            !gameData.IsCutscene
                            && map[y][x + 2] != '('
                            && map[y][x + 2] != ')'
                            && map[y][x + 2] != '|'
                            && map[y][x + 2] != '/'
                            && map[y][x + 2] != '\\'
                            && map[y][x + 2] != '-'
                            && map[y][x + 2] != '_'
                            )
                        {
                            gameData.Coordinates[0]++;
                        }
                        break;
                    case ConsoleKey.E:
                        if (gameData.CanInteract)
                        {
                            gameData.IsCutscene = true;
                        }
                        break;
                    case ConsoleKey.Escape:
                        gameData.IsRunning = false;
                        break;
                }
                if (
                     map[gameData.Coordinates[1]][gameData.Coordinates[0] - 1] == '♞'
                     && !gameData.EntryTalk
                     )
                {
                    gameData.CanInteract = true;
                    gameData.CutsceneNumber = 0;
                }
                else if (
                    map[gameData.Coordinates[1]][gameData.Coordinates[0] + 1] == 'o'
                )
                {
                    gameData.CanInteract = true;
                    gameData.CutsceneNumber = 1;
                }
                else if (
                    map[gameData.Coordinates[1]][gameData.Coordinates[0]] == '#'
                )
                {
                    Random rnd = new Random();
                    int num = rnd.Next(10);
                    if (num < 2) gameData.IsEncounter = true;
                    gameData.CurrentEnemy = new Charmander(1, 3);
                }
                else
                {
                    gameData.CanInteract = false;
                    gameData.IsEncounter = false;
                }
            }
            if (gameData.IsCutscene)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Spacebar:
                        gameData.CutsceneDialog++;
                        break;
                    case ConsoleKey.Escape:
                        gameData.IsRunning = false;
                        break;
                }
            }
            if (gameData.IsEncounter)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.Escape:
                        gameData.IsRunning = false;
                        break;
                }
            }
        }
    }
}