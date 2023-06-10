namespace Pokemon
{
    class GameData
    {
        public int[] Coordinates { get; set; } = new int[2] { 1, 1 };
        public string Name { get; set; } = "Player";
        public int Potions { get; set; } = 3;
        public Map Map { get; set; } = new Map();
        public bool IsRunning { get; set; } = true;
    }
}