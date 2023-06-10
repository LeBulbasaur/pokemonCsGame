namespace Pokemon
{
    class GameData
    {
        public int[] Coordinates { get; set; } = new int[2] { 5, 10 };
        public string Name { get; set; } = "Player";
        public int Potions { get; set; } = 3;
        public int World { get; set; } = 0;
        public bool IsFighting { get; set; } = false;
        public bool IsCutscene { get; set; } = false;
        public bool IsRunning { get; set; } = true;
    }
}