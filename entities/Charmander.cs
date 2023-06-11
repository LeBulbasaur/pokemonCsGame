namespace Pokemon
{
    class Charmander : Pokemon
    {
        public Charmander(int level)
        {
            Name = "Charmander";
            Level = level;
            Experience = 0;
            MaxHP = 20;
            CurrentHP = 20;
            Type = Types.Fire;
        }

        public void Ember()
        {
            Console.WriteLine("Charmander used Ember!");
        }

        public void FireSpin()
        {
            Console.WriteLine("Charmander used Fire Spin!");
        }
    }
}