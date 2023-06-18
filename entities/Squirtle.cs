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
            MaxHP = 20 * level;
            CurrentHP = MaxHP;
            Type = Types.Water;
        }
    }
}