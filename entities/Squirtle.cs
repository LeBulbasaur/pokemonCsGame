namespace Pokemon
{
    class Squirtle : Pokemon
    {
        public Squirtle()
        {
            Name = "Squirtle";
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