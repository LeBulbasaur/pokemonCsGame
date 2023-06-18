namespace Pokemon
{
    class Controls
    {
        public static void KeyboardEvent(GameData gameData, string[] map)
        {
            char nurse = '+';
            char oak = '♞';

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
                            && map[y - 1][x] != ';'
                            && map[y - 1][x] != nurse
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
                            gameData.Coordinates[1] = 8;
                            gameData.World = 9;
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
                            && map[y + 1][x] != ';'
                            && map[y + 1][x] != nurse
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
                            && map[y][x - 1] != ';'
                            && map[y][x - 1] != oak
                            && map[y][x - 1] != nurse
                            )
                        {
                            gameData.Coordinates[0]--;
                        }
                        if (map[y][x - 1] == '1')
                        {
                            gameData.Coordinates[0] = 44;
                            gameData.World = 1;
                        }
                        break;

                    // ARROW RIGHT
                    case ConsoleKey.RightArrow:
                        if (
                            !gameData.IsCutscene
                            && map[y][x + 1] != '('
                            && map[y][x + 1] != ')'
                            && map[y][x + 1] != '|'
                            && map[y][x + 1] != '/'
                            && map[y][x + 1] != '\\'
                            && map[y][x + 1] != '-'
                            && map[y][x + 1] != '_'
                            && map[y][x + 1] != ';'
                            && map[y][x + 1] != nurse
                            )
                        {
                            gameData.Coordinates[0]++;
                        }
                        if (map[y][x + 1] == '2')
                        {
                            gameData.Coordinates[0] = 2;
                            gameData.World = 2;
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
                     map[gameData.Coordinates[1]][gameData.Coordinates[0] - 1] == oak
                     && !gameData.EntryTalk
                     )
                {
                    gameData.CanInteract = true;
                    gameData.CutsceneNumber = 0;
                }
                else if (
                    map[gameData.Coordinates[1]][gameData.Coordinates[0] + 1] == nurse
                    || map[gameData.Coordinates[1]][gameData.Coordinates[0] - 1] == nurse
                    || map[gameData.Coordinates[1] - 1][gameData.Coordinates[0]] == nurse
                    || map[gameData.Coordinates[1] + 1][gameData.Coordinates[0]] == nurse
                )
                {
                    gameData.CanInteract = true;
                    gameData.CutsceneNumber = 9;
                }
                else if (
                    map[gameData.Coordinates[1]][gameData.Coordinates[0]] == 'q'
                )
                {
                    Random rnd = new Random();
                    int num = rnd.Next(10);
                    switch (num)
                    {
                        case 1:
                            gameData.CurrentEnemy = new Pidgey(1, rnd.Next(1, 4));
                            gameData.IsEncounter = true;
                            break;
                        case 2:
                            gameData.CurrentEnemy = new Spearow(1, rnd.Next(1, 4));
                            gameData.IsEncounter = true;
                            break;
                    }
                }
                else if (
                    map[gameData.Coordinates[1]][gameData.Coordinates[0]] == 'w'
                )
                {
                    Random rnd = new Random();
                    int num = rnd.Next(10);
                    switch (num)
                    {
                        case 1:
                            gameData.CurrentEnemy = new Pidgey(2, rnd.Next(1, 4));
                            gameData.IsEncounter = true;
                            break;
                        case 2:
                            gameData.CurrentEnemy = new Spearow(2, rnd.Next(1, 4));
                            gameData.IsEncounter = true;
                            break;
                        case 3:
                            gameData.CurrentEnemy = new Rattata(2, rnd.Next(1, 4));
                            gameData.IsEncounter = true;
                            break;
                    }
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