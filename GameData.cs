using System.Media;

namespace Pokemon
{
    class GameData
    {
        // add soundplayer
        // public SoundPlayer soundPlayer = new SoundPlayer();
        public int[] Coordinates
        { get; set; } = new int[2] { 8, 8 };
        public string Name { get; set; } = "Player";
        public List<Pokemon> Pokemons { get; set; } = new List<Pokemon> { };
        public int ChosenPokemon { get; set; } = 0;
        public int Potions { get; set; } = 0;
        public int World { get; set; } = 0;
        public bool IsEncounter { get; set; } = false;
        public Pokemon CurrentEnemy;
        public bool CanInteract { get; set; } = false;
        public bool IsCutscene { get; set; } = true;
        public int CutsceneNumber { get; set; } = -1;
        public int CutsceneDialog { get; set; } = 0;
        public bool IsRunning { get; set; } = true;
        public bool EntryTalk { get; set; } = false;
        public bool Enemy1Defeated { get; set; } = false;
        public bool FightingEnemy1 { get; set; } = false;
        public bool Enemy2Defeated { get; set; } = false;
        public bool FightingEnemy2 { get; set; } = false;
    }
}