
using InternshipDungeonCrawler.Data.Models.Monsters;
using System;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Ranger : Player
    {
        public Ranger()
        {
            MaxHealth *= 2;
            Damage *= 2;
        }
        public int CritChance { get; set; } = 5;
        public int StunChance { get; set; } = 5;


        public override void NextLevel()
        {
            base.NextLevel();
            (DataStore.Player as Ranger).StunChance += 5;
            (DataStore.Player as Ranger).CritChance += 5;
        }
        public override void Attack()
        {
            var random = new Random();
            if (random.Next(1, 100) <= CritChance)
            {
                DataStore.Enemy.Health -= 2 * DataStore.Player.Damage;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("CRITICAL HIT!");
                Console.ResetColor();
                Console.WriteLine("You attacked the " + DataStore.Enemy.Name + " and caused " + 2 * DataStore.Player.Damage + " damage points");
            }
            if (random.Next(1, 100) <= StunChance)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU STUNNED THE MONSTER!");
                Console.ResetColor();
                base.Attack();
                Console.WriteLine("Press any key to attack again:");
                Console.ReadKey();
                Attack();
            }
            else
            {
                base.Attack();
            }
        }


        public override string ToString()
        {
            return $"{base.ToString()}\nCRIT chance: {10*CritChance}%\nSTUN chance: {10*StunChance}%";
        }
    }
}
