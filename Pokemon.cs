namespace Pokemon
{
    class Pokemon
    {
        public string Name { get; set; } = "";
        public int Level { get; set; }
        public int Experience { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public Types Type { get; set; }

        public void Attack()
        {
            Console.WriteLine("Pokemon attacked!");
        }

        public void Defend()
        {
            Console.WriteLine("Pokemon defended!");
        }

        public void Heal()
        {
            if (CurrentHP == MaxHP)
            {
                Console.WriteLine("Pokemon is already at full health!");
            }
            else if (MaxHP - CurrentHP < 5)
            {
                CurrentHP = MaxHP;
                Console.WriteLine("Pokemon healed!");
            }
            else
            {
                CurrentHP += 5;
                Console.WriteLine("Pokemon healed!");
            }
        }
        public void Withdraw()
        {
            Console.WriteLine($"{Name} used Withdraw!");
        }
    }
}