using System;
using InternshipDungeonCrawler.Data.Models.Player;
using InternshipDungeonCrawler.Data.Models;

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
                Console.WriteLine("Choose your hero type:\t\t(0 to quit)\n" +
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
                    "\t-each attack has a chance to CRIT (deal double damage) or STUN (attack again without playing rock/paper/scissors) an enemy\n");
                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        var player = new Warrior
                        {
                            Name = heroName,
                            MaxHealth = 200,
                            CurrentHealth = 200,
                            Damage = 10
                        };
                        break;
                    case "2":
                        var player = new Mage
                        {
                            Name = heroName,
                            MaxHealth = 100,
                            CurrentHealth = 100,
                            Damage = 20
                        };
                        break;
                    case "3":

                        break;
                    default:
                        Console.WriteLine("Wrong input. Please enter 0, 1, 2, or 3.");
                        break;
                }
            }

        }
    }
}
