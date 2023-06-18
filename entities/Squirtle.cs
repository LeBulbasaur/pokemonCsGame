namespace Pokemon
{
    class Squirtle : Pokemon
    {
        public Squirtle(int level, int experience)
        {
            Name = "Squirtle";
            Level = level;
            Damage = 5;
            Experience = experience;
            MaxHP = 20;
            CurrentHP = 20;
            Type = Types.Water;
        }
    }
}