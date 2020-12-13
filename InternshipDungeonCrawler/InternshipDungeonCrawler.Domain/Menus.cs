using InternshipDungeonCrawler.Data;
using System;

namespace InternshipDungeonCrawler.Domain
{
    public class Menus
    {
        public static void StartScreen()
        {
            Console.WriteLine("Heroji Moci i Magije (TM)");
            Console.WriteLine("\nChoose your hero name:\t\t(0 to quit)");
            var heroName = Console.ReadLine();
            if (heroName == "0")
            {
                Environment.Exit(0);
            }
            var typeChosen = false;
            var settingsChosen = false;
            while (!typeChosen || !settingsChosen)
            {
                Console.WriteLine("Welcome, " + heroName +
                    "\nChoose your hero type:\t\t(0 to quit)\n" +
                    "\n1 - Warrior:\n" +
                    "\t-has lots of HP\n" +
                    "\t-does little damage\n" +
                    "\t-SPECIAL: Rage Attack - spend 15% of your max HP to DOUBLE your damage dealt for one round\n" +
                    "\n2 - Mage:\n" +
                    "\t-has little HP\n" +
                    "\t-does lots of damage\n" +
                    "\t-uses MANA to fight (if mana ammount is at 0 player can not attack, but only regenerate mana)\n" +
                    "\tSPECIAL: Revive - a mage can come back from the dead once per playthrough\n" +
                    "\n3 - Ranger:\n" +
                    "\t-moderate HP\n" +
                    "\t-moderate damage\n" +
                    "\t-each attack has a chance to CRIT or STUN an enemy\n");
                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        typeChosen = true;
                        break;
                    case "1":
                        PlayerCreator.Warrior(heroName);
                        typeChosen = true;
                        break;
                    case "2":
                        PlayerCreator.Mage(heroName);
                        typeChosen = true;
                        break;
                    case "3":
                        PlayerCreator.Ranger(heroName);
                        typeChosen = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid input. Please enter 0, 1, 2, or 3.\n");
                        break;
                }
                Console.WriteLine("Would you like to set your own health or resume with the default option?\t\t(default = " + DataStore.Player.MaxHealth + ")" +
                    "\n1 - default" +
                    "\n2 - custom");
                switch (Console.ReadLine())
                {
                    case "1":
                        settingsChosen = true;
                        break;
                    case "2":
                        while (!settingsChosen)
                        {
                            Console.WriteLine("Please enter your desired health ammount: ");
                            var userInputHp = Console.ReadLine();
                            if (int.TryParse(userInputHp, out int health))
                            {
                                DataStore.Player.MaxHealth = health;
                                DataStore.Player.CurrentHealth = health;
                                settingsChosen = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid input. Please try again.");
                            }
                        }
                        break;
                }
            }
            while (true)
            {
                if (DataStore.EncounterCount < 10)
                {

                }
                else
                {
                    EndScreen(heroName);
                    return;
                }
            }
        }

        private static void EndScreen(string heroName)
        {
            Console.WriteLine("You go forwards and see a familiar face. It's Toad!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Toad: Thank you " + heroName + "!\n" +
                "But our princess is in another castle!");
            Console.ResetColor();
            Console.WriteLine("\n\nWould you like to play again?" +
                "\n0 to quit, any other key to play again:");
            var playAgain = Console.ReadLine();
            if (playAgain == "0")
            {
                return;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}