namespace Pokemon
{
    // this class is responsible for displaying cutscenes
    // the cutscene number is a number that determines which cutscene to display
    // the cutscene number is set in the Controls.KeyboardEvent method
    // the cutscene dialog is a number that determines which dialog to display
    // the cutscene dialog is set in the Cutscene.EntryDialog method

    class Cutscene
    {

        public static void PokemonPrologue(GameData gameData)
        {
            string[] logo = ASCII.Logo();
            string[] night = ASCII.StarryNight();

            switch (gameData.CutsceneDialog)
            {
                case 0:
                    foreach (string line in logo)
                    {
                        Console.WriteLine(line);
                    }
                    break;
                case 1:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("In the world of dreams, a young boy from Kanto region experienced a vivid and extraordinary vision.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 2:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("In his dream, he became the ultimate Pokemon Trainer, achieving greatness and conquering the legendary Celestial Tower atop Mt. Eternity.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 3:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("The dream was so vivid and captivating that it lingered in his mind even after he woke up from his post-lunch nap under a shady tree.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 4:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("As he opened his eyes, the warm sunlight greeted him, and he felt a sense of determination stirring within his heart.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 5:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Inspired by his dream, the boy resolved to embark on a real-life journey to become the very best Pokemon Trainer, just as he had envisioned.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 6:
                    foreach (string line in night)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("With a small backpack slung over his shoulder and a glimmer of excitement in his eyes, he stepped out into the vast and wondrous world of Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    gameData.IsCutscene = false;
                    gameData.CutsceneDialog = 0;
                    break;
            }
        }
        public static void EntryDialog(GameData gameData)
        {
            string[] oak = ASCII.OakArt();
            string[] bulbasaurArt = ASCII.BulbasaurArtShorter();
            string[] charmanderArt = ASCII.CharmanderArtShorter();
            string[] squirtleArt = ASCII.SquirtleArtShorter();

            switch (gameData.CutsceneDialog)
            {
                case 0:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Welcome to the world of Pokemon!");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 1:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("My name is Oak.");
                    Console.WriteLine("People call me the Pokemon Prof.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 2:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("This world is inhabited by creatures called Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 3:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("For some people, Pokemon are pets.");
                    Console.WriteLine("Others use them for fights.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 4:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Myself...");
                    Console.WriteLine("I study Pokemon as a profession.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 5:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("First, what is your name?");
                    Console.CursorVisible = true;
                    Console.WriteLine("Enter your name:");
                    Console.Write("> ");
                    string? name = Console.ReadLine();
                    if (name != null && name.Length > 1)
                    {
                        gameData.Name = char.ToUpper(name[0]) + name.Substring(1);
                    }
                    else Console.WriteLine("Invalid name. You will be called Player.");
                    Console.CursorVisible = false;
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 6:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine($"Right! So your name is {gameData.Name}.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 7:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine($"{gameData.Name}!");
                    Console.WriteLine("Your very own Pokemon legend is about to unfold!");
                    Console.WriteLine("A world of dreams and adventures with Pokemon awaits!");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 8:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("But first, you have to choose your starter Pokemon!");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 9:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("You have three choices:");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (string line in bulbasaurArt)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nBulbasaur, the grass type Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (string line in charmanderArt)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nCharmander, the fire type Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    foreach (string line in squirtleArt)
                    {
                        Console.WriteLine(line);
                    }
                    Console.ResetColor();
                    Console.WriteLine("\nSquirtle, the water type Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 13:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Which Pokemon do you choose?");
                    Console.WriteLine("Enter 1 for Bulbasaur, 2 for Charmander, or 3 for Squirtle.");
                    Console.CursorVisible = true;
                    Console.Write("> ");
                    string? choice = Console.ReadLine();
                    if (choice != null)
                    {
                        switch (choice)
                        {
                            case "1":
                                {
                                    Bulbasaur bulbasaur = new Bulbasaur(1, 0);
                                    gameData.Pokemons.Insert(0, bulbasaur);
                                    break;
                                }
                            case "2":
                                {
                                    Charmander charmander = new Charmander(1, 0);
                                    gameData.Pokemons.Insert(0, charmander);
                                    break;
                                }
                            case "3":
                                {
                                    Squirtle squirtle = new Squirtle(1, 0);
                                    gameData.Pokemons.Insert(0, squirtle);
                                    break;
                                }
                            default:
                                {
                                    Bulbasaur bulbasaur = new Bulbasaur(1, 0);
                                    Console.WriteLine("Invalid choice. You will be given Bulbasaur.");
                                    gameData.Pokemons.Insert(0, bulbasaur);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Bulbasaur bulbasaur = new Bulbasaur(1, 0);
                        Console.WriteLine("Invalid choice. You will be given Bulbasaur.");
                        gameData.Pokemons.Insert(0, bulbasaur);
                    }
                    Console.WriteLine("You chose " + gameData.Pokemons[0].Name + "!");
                    Console.CursorVisible = false;
                    Console.WriteLine("\nPress Space to continue...");
                    break;

                case 14:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Now that you have your Pokemon, you can begin your journey!");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 15:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("But first, you need to know how to use your Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 16:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("You can use your Pokemon to fight other Pokemon.");
                    Console.WriteLine("You can also use items to heal your Pokemon.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 17:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("If you want to heal your Pokemon before battle, search for a nurse Joy (marked as + ).");
                    Console.WriteLine("She will be happy to heal your Pokemons!");
                    Console.WriteLine("She visited me earlier so maybe you can find her somewhere nearby.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 18:
                    Console.WriteLine("You can train your new friend by battling other Pokemons.");
                    Console.WriteLine("Actually, wild Pidgeys and Spearows often visit my garden.");
                    Console.WriteLine("Maybe try AKSDJHASKJDHASKJDHASDKJHASDKJAHSDKAJSDH ");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                // case 18:
                //     foreach (string line in oak)
                //     {
                //         Console.WriteLine(line);
                //     }
                //     Console.WriteLine("\n");
                //     Console.WriteLine("You can also catch wild Pokemon to add to your team.");
                //     Console.WriteLine("\nPress Space to continue...");
                //     break;
                case 19:
                    foreach (string line in oak)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Good luck on your journey!");
                    Console.WriteLine("\nPress Space to continue...");
                    gameData.IsCutscene = false;
                    gameData.CutsceneDialog = 0;
                    gameData.EntryTalk = true;
                    break;
            }
        }

        public static void NurseJoy(GameData gameData)
        {
            string[] nurseJoy = ASCII.JoyArt();
            if (gameData.Pokemons.Count == 0)
            {
                foreach (string line in nurseJoy)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Hello traveler! I'm Nurse Joy and my job is to heal Pokemons.");
                Console.WriteLine("However, you don't have any Pokemons with you.");
                Console.WriteLine("Maybe visit Professor Oak to get one?");
                Console.WriteLine("He lives in the house a little bit to the north.");
                Console.WriteLine("\nPress Space to continue...");
                gameData.IsCutscene = false;
                gameData.CutsceneDialog = 0;
                return;
            }
            else
            {
                switch (gameData.CutsceneDialog)
                {
                    case 0:
                        foreach (string line in nurseJoy)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Welcome to my mobile hospital!");
                        Console.WriteLine("My job is to heal Pokemon. Let me see how your friend is doing...");
                        Console.WriteLine("\nPress Space to continue...");
                        break;
                    case 1:
                        foreach (string line in nurseJoy)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Hmm... Let's do this, than that, and finally this...");
                        gameData.Pokemons.ForEach(pokemon => pokemon.CurrentHP = pokemon.MaxHP);
                        Console.WriteLine("\nPress Space to continue...");
                        break;
                    case 2:
                        foreach (string line in nurseJoy)
                        {
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Pokemon have been healed!");
                        Console.WriteLine("Visit me whenever you want!");
                        Console.WriteLine("\nPress Space to continue...");
                        gameData.IsCutscene = false;
                        gameData.CutsceneDialog = 0;
                        break;
                }
            }
        }
    }
}