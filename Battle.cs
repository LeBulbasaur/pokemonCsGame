namespace Pokemon
{
    class Battle
    {
        private static void PlayerMove(Pokemon enemyPokemon, GameData gameData)
        {
            bool invalidInput = false;

            enemyPokemon.Draw(enemyPokemon.Name);
            Console.WriteLine("\n");
            Pokemon playerPokemon = gameData.Pokemons[gameData.ChosenPokemon];
            Console.WriteLine($"{playerPokemon.Name}'s HP: {playerPokemon.CurrentHP}/{playerPokemon.MaxHP}");
            Console.WriteLine($"Enemy HP: {enemyPokemon.CurrentHP}/{enemyPokemon.MaxHP}");
            Console.WriteLine("\nInventory:");
            Console.WriteLine($"Potions: {gameData.Potions}\n");
            Console.WriteLine($"Go {playerPokemon.Name}!");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Use potion");
            Console.WriteLine("3. Run");
            Console.Write("> ");
            Console.CursorVisible = true;
            string input = Console.ReadLine();
            Console.CursorVisible = false;
            switch (input)
            {
                case "1":
                    Console.Clear();
                    enemyPokemon.Draw(enemyPokemon.Name);
                    Console.WriteLine("\n");
                    playerPokemon.Attack(playerPokemon.Damage + playerPokemon.Level, gameData);
                    break;
                case "2":
                    Console.Clear();
                    playerPokemon.Draw(playerPokemon.Name);
                    Console.WriteLine("\n");
                    if (gameData.Potions > 0)
                    {
                        playerPokemon.CurrentHP = playerPokemon.MaxHP;
                        Console.WriteLine($"{playerPokemon.Name} has been healed! {playerPokemon.Name} has now {playerPokemon.CurrentHP} HP remaining!");
                        gameData.Potions--;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have no potions!");
                        break;
                    }
                case "3":
                    gameData.IsEncounter = false;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    invalidInput = true;
                    break;
            }
            if (invalidInput) PlayerMove(enemyPokemon, gameData);
            else
            {
                Console.WriteLine("\nPress Space to continue...");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar) return;
            }
        }

        private static void EnemyMove(Pokemon enemyPokemon, GameData gameData)
        {
            Console.Clear();
            Pokemon playerPokemon = gameData.Pokemons[gameData.ChosenPokemon];
            playerPokemon.Draw(playerPokemon.Name);
            Console.WriteLine("\n");
            playerPokemon.CurrentHP -= enemyPokemon.Damage + enemyPokemon.Level;

            if (playerPokemon.CurrentHP <= 0)
            {
                playerPokemon.CurrentHP = 0;
                Console.WriteLine($"{enemyPokemon.Name} attacked! {playerPokemon.Name} fainted!");
                Console.WriteLine("\n");
                Console.WriteLine("\nPress Space to continue...");
                ConsoleKeyInfo keyInfo2 = Console.ReadKey(true);
                gameData.IsEncounter = false;
                if (gameData.FightingEnemy1)
                {
                    gameData.FightingEnemy1 = false;
                }
                if (gameData.FightingEnemy2)
                {
                    gameData.FightingEnemy2 = false;
                }
                if (keyInfo2.Key == ConsoleKey.Spacebar) return;
            }
            Console.WriteLine($"{enemyPokemon.Name} attacked! {playerPokemon.Name} has {playerPokemon.CurrentHP} HP remaining!");
            Console.WriteLine("\n");

            Console.WriteLine("Press Space to continue...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Spacebar) return;
        }
        public static void StartBattle(GameData gameData)
        {
            Console.Clear();
            if (gameData.Pokemons.Count == 0 || gameData.Pokemons[gameData.ChosenPokemon].CurrentHP == 0)
            {
                Pokemon enemyPokemon = gameData.CurrentEnemy;
                Console.WriteLine($"A wild {enemyPokemon.Name} appeared!\n");
                enemyPokemon.Draw(enemyPokemon.Name);
                Console.WriteLine("\n");
                Console.WriteLine("You have no Pokemon!");
                Console.WriteLine("Press Space to run");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    gameData.IsEncounter = false;
                    return;
                }
            }
            else
            {
                Pokemon enemyPokemon = gameData.CurrentEnemy;

                Console.WriteLine($"A wild {enemyPokemon.Name} appeared!\n");
                while (enemyPokemon.CurrentHP > 0 && gameData.Pokemons[gameData.ChosenPokemon].CurrentHP > 0 && gameData.IsEncounter)
                {
                    PlayerMove(enemyPokemon, gameData);
                    if (gameData.IsEncounter) EnemyMove(enemyPokemon, gameData);
                }
            }
        }
    }
}