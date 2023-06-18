namespace Pokemon
{
    class Charmander : Pokemon
    {
        public Charmander(int level, int experience)
        {
            Name = "Charmander";
            Level = level;
            Damage = 5;
            Experience = experience;
            MaxHP = 20 * level;
            CurrentHP = MaxHP;
            Type = Types.Fire;
        }

    }
}