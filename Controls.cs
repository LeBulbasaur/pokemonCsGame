namespace Pokemon
{
    class Controls
    {
        public static void KeyboardEvent(GameData gameData, string[] worldMap)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            int x = gameData.Coordinates[0];
            int y = gameData.Coordinates[1];

            if (
                keyInfo.Key == ConsoleKey.UpArrow
                && y > 0
                && worldMap[y - 1][x] != '='
                )
            {
                y--;
            }
            else if (
                keyInfo.Key == ConsoleKey.DownArrow
                && y < 10
                && worldMap[y + 1][x] != '='
                )
            {
                y++;
            }
            else if (
                keyInfo.Key == ConsoleKey.LeftArrow
                && x > 0
                && worldMap[y][x - 1] != '='
                )
            {
                x--;
            }
            else if (
                keyInfo.Key == ConsoleKey.RightArrow
                && x < 31
                && worldMap[y][x + 1] != '='
                )
            {
                x++;
            }
            else if (keyInfo.Key == ConsoleKey.Escape)
            {
                gameData.IsRunning = false;
            }
            gameData.Coordinates[0] = x;
            gameData.Coordinates[1] = y;
        }
    }
}