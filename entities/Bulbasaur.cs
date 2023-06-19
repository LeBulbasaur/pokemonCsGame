namespace Pokemon
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(int level, int experience)
        {
            Name = "Bulbasaur";
            Level = level;
            Damage = 5;
            Experience = experience;
            MaxHP = 18 + 2 * level;
            CurrentHP = MaxHP;
            Type = Types.Grass;
        }
    }
}