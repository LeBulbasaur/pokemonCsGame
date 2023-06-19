namespace Pokemon
{
    class Rattata : Pokemon
    {
        public Rattata(int level, int experience)
        {
            Name = "Rattata";
            Level = level;
            Damage = 4;
            Experience = experience;
            MaxHP = 18 + 2 * level;
            CurrentHP = MaxHP;
            Type = Types.Normal;
        }
    }
}