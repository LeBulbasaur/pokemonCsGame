namespace Pokemon
{
    class GameData
    {
        public int[] Coordinates { get; set; } = new int[2] { 8, 8 };
        public string Name { get; set; } = "Player";
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon> { };
        public int ChosenPokemon { get; set; } = 0;
        public int Potions { get; set; } = 4;
        public int World { get; set; } = 0;
        public bool IsEncounter { get; set; } = false;
        public Pokemon CurrentEnemy;
        public bool CanInteract { get; set; } = false;
        public bool IsCutscene { get; set; } = false;
        public int CutsceneNumber { get; set; } = -1;
        public int CutsceneDialog { get; set; } = 0;
        public bool IsRunning { get; set; } = true;
        public bool EntryTalk { get; set; } = false;
    }
}