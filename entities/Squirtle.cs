namespace Pokemon
{
    class Squirtle : Pokemon
    {
        public Squirtle(int level)
        {
            Name = "Squirtle";
            Level = level;
            Experience = 0;
            MaxHP = 20;
            CurrentHP = 20;
            Type = Types.Water;
        }

        public void WaterGun()
        {
            Console.WriteLine("Squirtle used Water Gun!");
        }

        public void Bubble()
        {
            Console.WriteLine("Squirtle used Bubble!");
        }
    }
}