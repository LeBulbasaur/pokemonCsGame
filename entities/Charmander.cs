namespace Pokemon
{
    class Charmander : Pokemon
    {
        public Charmander()
        {
            Name = "Charmander";
            MaxHP = 20;
            CurrentHP = 20;
            Type = "Fire";
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