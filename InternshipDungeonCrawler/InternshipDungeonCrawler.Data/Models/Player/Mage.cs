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
        public int Mana { get; set; } = 5;
        public int MaxMana { get; set; } = 5;
        public bool HasRevived { get; set; } = false;


        public override void NextLevel()
        {
            base.NextLevel();
            (DataStore.Player as Mage).MaxMana++;
            (DataStore.Player as Mage).Mana = (DataStore.Player as Mage).MaxMana;
        }
        public override void Attack()
        {
            if(Mana == MaxMana)
            {
                base.Attack();
                Console.WriteLine("You used 1 mana for this attack.");
            }
            else if (Mana > 0)
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
                        base.Attack();
                        Console.WriteLine("You used 1 mana for this attack.");
                        done = true;
                    }
                    else if (userInput == "2")
                    {
                        ManaRegen(DataStore.Player as Mage);
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
                ManaRegen(DataStore.Player as Mage);
            }
        }
        private void ManaRegen(Mage Player)
        {
            Player.Mana++;
            Console.WriteLine("You have regenerated 1 mana.");
        }
        public override string ToString()
        {
            return $"{ base.ToString()}\nMANA: {Mana}/{MaxMana} {Visuals.ProgressBar(Mana, MaxMana)}";
        }
    }
}