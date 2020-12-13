using System;
using InternshipDungeonCrawler.Data.Models.Player;
using InternshipDungeonCrawler.Data.Models;
using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Domain;
using static System.Net.Mime.MediaTypeNames;

namespace InternshipDungeonCrawler.Presentation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Heroji Moci i Magije (TM)");
            Console.WriteLine("\nChoose your hero name:\t\t(0 to quit)");
            var heroName = Console.ReadLine();
            if (heroName == "0")
            {
                Environment.Exit(0);
            }
            var done = false;
            while (!done)
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
                        done = true;
                        break;
                    case "1":
                        PlayerCreator.Warrior(heroName);
                        done = true;
                        break;
                    case "2":
                        PlayerCreator.Mage(heroName);
                        done = true;
                        break;
                    case "3":
                        PlayerCreator.Ranger(heroName);
                        done = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input. Please enter 0, 1, 2, or 3.\n");
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
                        Main();
                        return;
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
