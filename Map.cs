namespace Pokemon
{
    class Map
    {
        string[] worldMap = new string[12]{
            "================================",
            "|                     =        |",
            "|                  =           |",
            "|                              |",
            "|                              |",
            "|               =              |",
            "|                              |",
            "|                  =           |",
            "|                     =        |",
            "|                              |",
            "|                              |",
            "================================"
        };

        public string[] GetWorldMap(int x, int y)
        {
            string[] map = (string[])worldMap.Clone();
            map[y] = map[y].Remove(x, 1).Insert(x, "𓀠");
            Console.WriteLine(worldMap[y][x + 1]);
            return map;
        }
    }
}