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
            MaxHP = 20;
            CurrentHP = 20;
            Type = Types.Grass;
        }
    }
}