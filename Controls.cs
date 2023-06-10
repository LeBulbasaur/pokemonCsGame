namespace Pokemon
{
    class Controls
    {
        public static void KeyboardEvent(GameData gameData, string[] map)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            int x = gameData.Coordinates[0];
            int y = gameData.Coordinates[1];

            switch (keyInfo.Key)
            {

                // ARROW UP
                case ConsoleKey.UpArrow:
                    if (
                        map[y - 1][x] != '('
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
                        map[y + 1][x] != '('
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
                        map[y][x - 1] != '('
                        && map[y][x - 1] != ')'
                        && map[y][x - 1] != '|'
                        && map[y][x - 1] != '/'
                        && map[y][x - 1] != '\\'
                        && map[y][x - 1] != '-'
                        && map[y][x - 1] != '_'
                        )
                    {
                        gameData.Coordinates[0]--;
                    }
                    if (map[y][x - 1] == '♞')
                    {
                        gameData.IsCutscene = true;
                    }
                    break;

                // ARROW RIGHT
                case ConsoleKey.RightArrow:
                    if (
                        map[y][x + 2] != '('
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
                case ConsoleKey.Escape:
                    gameData.IsRunning = false;
                    break;
            }

        }
    }
}