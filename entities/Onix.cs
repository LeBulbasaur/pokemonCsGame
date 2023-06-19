namespace Pokemon
{
    class Onix : Pokemon
    {
        public Onix(int level, int experience)
        {
            Name = "Onix";
            Level = level;
            Damage = 5;
            Experience = experience;
            MaxHP = 20 + 2 * level;
            CurrentHP = MaxHP;
            Type = Types.Rock;
        }
    }
}