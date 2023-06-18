namespace Pokemon
{
    class Renderer
    {
        public static void Render(GameData gameData, string[] map)
        {
            Console.WriteLine($"x: {gameData.Coordinates[0]} y: {gameData.Coordinates[1]}");
            foreach (string line in map)
            {
                foreach (char character in line)
                {
                    switch (character)
                    {
                        case '♥':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(character);
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(character);
                            break;
                        case 'D':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(character);
                            break;
                        case '|':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(character);
                            break;
                        case '_':
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write(character);
                            break;
                        case '/':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(character);
                            break;
                        case '\\':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(character);
                            break;
                        case '(':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(character);
                            break;
                        case ')':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(character);
                            break;
                        case '0':
                            Console.Write(' ');
                            break;
                        case '1':
                            Console.Write(' ');
                            break;
                        case '9':
                            Console.Write(' ');
                            break;
                        default:
                            Console.Write(character);
                            break;
                    }
                    Console.ResetColor();
                }
                Console.Write("\n");

            }
            if (gameData.CanInteract && !gameData.IsCutscene)
            {
                Console.WriteLine("\nPress E to interact");
            }
            else if (gameData.IsEncounter)
            {
                Console.WriteLine("Press E to fight");
            }
            else
            {
                Console.WriteLine("\nInventory:");
                Console.WriteLine($"Potions: {gameData.Potions}");

                if (gameData.Pokemons.Count > 0)
                {
                    Console.WriteLine($"\nPokemons:");
                    foreach (Pokemon pokemon in gameData.Pokemons)
                    {
                        Console.WriteLine($"Name: {pokemon.Name} HP: {pokemon.CurrentHP}/{pokemon.MaxHP} Level: {pokemon.Level}");
                    }
                }
                Console.WriteLine("\nPress ESC to quit");
            }
        }
    }
}