using System;
using InternshipDungeonCrawler.Data.Models.Monsters;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Mage : Player
    {
        public Mage()
        {
            Damage *= 3;
        }
        public int CurrentMana { get; set; } = 5;
        public int MaxMana { get; set; } = 5;
        public bool HasRevived { get; set; } = false;
        public override void Attack(Player Player, Monster Enemy)
        {
            if(CurrentMana == MaxMana)
            {
                base.Attack(Player, Enemy);
                Console.WriteLine("You used 1 mana for this attack.");
            }
            else if (CurrentMana > 0)
            {
                var done = false;
                while (!done)
                {
                    Console.WriteLine("Select your move:" +
                        "\n\t1 - Attack" +
                        "\n\t2 - Regenerate mana");
                    var userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        base.Attack(Player, Enemy);
                        Console.WriteLine("You used 1 mana for this attack.");
                        done = true;
                    }
                    else if (userInput == "2")
                    {
                        ManaRegen(Player as Mage);
                        done = true;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid input. Please try again");
                    }
                }
            }
            else
            {
                Console.WriteLine("You do not have enough mana to attack.");
                ManaRegen(Player as Mage);
            }
        }
        private void ManaRegen(Mage Player)
        {
            Player.CurrentMana++;
            Console.WriteLine("You have regenerated 1 mana.");
        }
        public override string ToString()
        {
            return $"{ base.ToString()}\nMANA: {CurrentMana}/{MaxMana} {Visuals.ProgressBar(CurrentMana, MaxMana)}";
        }
    }
}