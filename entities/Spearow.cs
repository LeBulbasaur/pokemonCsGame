namespace Pokemon
{
    class Spearow : Pokemon
    {
        public Spearow(int level, int experience)
        {
            Name = "Spearow";
            Level = level;
            Damage = 3;
            Experience = experience;
            MaxHP = 18 + 2 * level;
            CurrentHP = MaxHP;
            Type = Types.Normal;
        }
    }
}