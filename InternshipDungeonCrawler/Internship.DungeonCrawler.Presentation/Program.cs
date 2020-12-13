using System;
using InternshipDungeonCrawler.Data.Models.Player;
using InternshipDungeonCrawler.Data.Models;
using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Domain;

namespace InternshipDungeonCrawler.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heroji Moci i Magije (TM)");
            Console.WriteLine("\nChoose your hero name:\t\t(0 to quit)");
            var heroName = Console.ReadLine();
            if (heroName == "0")
            {
                Environment.Exit(0);
            }
            while (true)
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
                        break;
                    case "1":
                        PlayerCreator.WarriorCreator(heroName);
                        break;
                    case "2":
                        PlayerCreator.MageCreator(heroName);
                        break;
                    case "3":
                        PlayerCreator.RangerCreator(heroName);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong input. Please enter 0, 1, 2, or 3.");
                        break;
                }
            }
        }
    }
}
