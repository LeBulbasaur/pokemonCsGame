namespace Pokemon
{
    class Bulbasaur : Pokemon
    {
        public Bulbasaur(int level)
        {
            Name = "Bulbasaur";
            Level = level;
            Experience = 0;
            MaxHP = 20;
            CurrentHP = 20;
            Type = Types.Grass;
        }

        public void VineWhip()
        {
            Console.WriteLine("Bulbasaur used Vine Whip!");
        }

        public void RazorLeaf()
        {
            Console.WriteLine("Bulbasaur used Razor Leaf!");
        }
    }
}