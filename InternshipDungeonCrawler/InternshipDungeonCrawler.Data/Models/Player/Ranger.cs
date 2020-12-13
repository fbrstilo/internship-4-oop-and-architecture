
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
        public int CritChance { get; set; } = 1;
        public int StunChance { get; set; } = 1;


        public override void NextLevel()
        {
            base.NextLevel();
            (DataStore.Player as Ranger).StunChance++;
            (DataStore.Player as Ranger).CritChance++;
        }
        public override void Attack()
        {
            var random = new Random();
            if (random.Next(1, 11) <= CritChance)
            {
                DataStore.Enemy.Health -= 3 * DataStore.Player.Damage;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("CRITICAL HIT!");
                Console.ResetColor();
                Console.WriteLine("You attacked the " + DataStore.Enemy.Name + " and caused " + 3 * DataStore.Player.Damage + " damage points");
            }
            if (random.Next(1, 11) <= StunChance)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU STUNNED THE MONSTER!");
                Console.ResetColor();
                base.Attack();
                Console.WriteLine("Press any key to attack again:");
                Console.ReadKey();
                Attack();
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nCRITchance: {10*CritChance}%\nSTUN chance: {10*StunChance}%";
        }
    }
}
