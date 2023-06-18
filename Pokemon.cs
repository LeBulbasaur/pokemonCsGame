namespace Pokemon
{
    class Pokemon
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Damage { get; set; }
        public int Experience { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public Types Type { get; set; }

        public void Draw(string pokemon)
        {
            switch (Type)
            {
                case Types.Grass:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case Types.Fire:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Types.Water:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            switch (pokemon)
            {
                case "Bulbasaur":
                    string[] bulbasaur = ASCII.BulbasaurArtShorter();
                    foreach (string line in bulbasaur)
                    {
                        Console.WriteLine(line);
                    }
                    break;
                case "Charmander":
                    string[] charmander = ASCII.CharmanderArtShorter();
                    foreach (string line in charmander)
                    {
                        Console.WriteLine(line);
                    }
                    break;
                case "Squirtle":
                    string[] squirtle = ASCII.SquirtleArtShorter();
                    foreach (string line in squirtle)
                    {
                        Console.WriteLine(line);
                    }
                    break;
            }
            Console.ResetColor();
        }

        public void Attack(int damage, GameData gameData)
        {
            if (gameData.CurrentEnemy.CurrentHP - damage <= 0)
            {
                gameData.CurrentEnemy.CurrentHP = 0;
                Console.WriteLine($"{gameData.CurrentEnemy.Name} has been attacked! {gameData.CurrentEnemy.Name} fainted!");
                Console.WriteLine($"{Name} gained {gameData.CurrentEnemy.Experience} experience!");
                Experience += gameData.CurrentEnemy.Experience;
                if (Experience >= 10)
                {
                    Level++;
                    MaxHP += 2;
                    CurrentHP = MaxHP;
                    Console.WriteLine($"{Name} leveled up! {Name} is now level {Level}!");
                    Experience -= 10;
                }
                gameData.IsEncounter = false;
                return;
            }
            gameData.CurrentEnemy.CurrentHP -= damage;
            Console.WriteLine($"{gameData.CurrentEnemy.Name} has been attacked! {gameData.CurrentEnemy.CurrentHP} HP remaining!");
        }
    }
}