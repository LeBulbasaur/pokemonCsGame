namespace Pokemon
{
    class Pidgey : Pokemon
    {
        public Pidgey(int level, int experience)
        {
            Name = "Pidgey";
            Level = level;
            Damage = 3;
            Experience = experience;
            MaxHP = 18 + 2 * level;
            CurrentHP = MaxHP;
            Type = Types.Normal;
        }
    }
}