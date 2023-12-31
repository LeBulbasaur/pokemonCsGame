namespace Pokemon
{
    class Map
    {
        string[] spawnMap = ASCII.SpawnMap();
        string[] firstMap = ASCII.FirstMap();
        string[] houseMap = ASCII.HouseMap();
        string[] secondMap = ASCII.SecondMap();
        string[] arenaMap = ASCII.ArenaMap();
        string[] arenaMapOpen = ASCII.ArenaMapOpen();
        public string[] GetWorldMap(GameData gameData, int x, int y)
        {
            string[] map = new string[13];
            switch (gameData.World)
            {
                case 0:
                    map = (string[])spawnMap.Clone();
                    break;
                case 1:
                    map = (string[])firstMap.Clone();
                    break;
                case 2:
                    map = (string[])secondMap.Clone();
                    break;
                case 7:
                    if (!gameData.Enemy1Defeated) map = (string[])arenaMap.Clone();
                    else map = (string[])arenaMapOpen.Clone();
                    break;
                case 9:
                    map = (string[])houseMap.Clone();
                    break;
            }

            map[y] = map[y].Remove(x, 1).Insert(x, "♥");
            return map;
        }
    }
}