namespace Pokemon
{
    class GameData
    {
        public int[] Coordinates { get; set; } = new int[2] { 5, 10 };
        public string Name { get; set; } = "Player";
        public List<string> Pokemons { get; set; } = new List<string> { };
        public List<string> Inventory { get; set; } = new List<string> { "potion", "potion", "potion", "potion" };
        public int World { get; set; } = 0;
        public bool IsFighting { get; set; } = false;
        public bool CanInteract { get; set; } = false;
        public bool IsCutscene { get; set; } = false;
        public int CutsceneNumber { get; set; } = 0;
        public int CutsceneDialog { get; set; } = 0;
        public bool EntryTalk { get; set; } = false;
        public bool IsRunning { get; set; } = true;
    }
}