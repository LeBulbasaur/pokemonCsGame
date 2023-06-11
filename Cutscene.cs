namespace Pokemon
{
    // this class is responsible for displaying cutscenes
    // the cutscene number is a number that determines which cutscene to display
    // the cutscene number is set in the Controls.KeyboardEvent method
    // the cutscene dialog is a number that determines which dialog to display
    // the cutscene dialog is set in the Cutscene.EntryDialog method

    class Cutscene
    {
        public static void EntryDialog(GameData gameData)
        {
            string[] oak = ASCII.OakArt();
            string[] bulbasaurArt = ASCII.BulbasaurArt();
            string[] charmanderArt = ASCII.CharmanderArt();
            string[] squirtleArt = ASCII.SquirtleArt();

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
                    string? choice = Console.ReadLine();
                    if (choice != null)
                    {
                        switch (choice)
                        {
                            case "1":
                                {
                                    Bulbasaur bulbasaur = new Bulbasaur(1);
                                    gameData.Pokemons.Insert(0, bulbasaur);
                                    break;
                                }
                            case "2":
                                {
                                    Charmander charmander = new Charmander(1);
                                    gameData.Pokemons.Insert(0, charmander);
                                    break;
                                }
                            case "3":
                                {
                                    Squirtle squirtle = new Squirtle(1);
                                    gameData.Pokemons.Insert(0, squirtle);
                                    break;
                                }
                            default:
                                {
                                    Bulbasaur bulbasaur = new Bulbasaur(1);
                                    Console.WriteLine("Invalid choice. You will be given Bulbasaur.");
                                    gameData.Pokemons.Insert(0, bulbasaur);
                                    break;
                                }
                        }
                    }
                    else
                    {
                        Bulbasaur bulbasaur = new Bulbasaur(1);
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
                    Console.WriteLine("You can also catch wild Pokemon to add to your team.");
                    Console.WriteLine("\nPress Space to continue...");
                    break;
                case 18:
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
    }
}