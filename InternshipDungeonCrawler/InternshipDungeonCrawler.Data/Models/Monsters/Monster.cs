using System;
using InternshipDungeonCrawler.Data.Models;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Monster
    {
        public int Health { get; set; } = 10 * DataStore.EncounterCount;
        public int MaxHealth { get; set; } = 10 * DataStore.EncounterCount;
        public int DamagePerAttack { get; set; } = 10 * DataStore.EncounterCount;
        public int XpWorth { get; set; } = 10 * DataStore.EncounterCount;
        public string Name { get; set; }

        virtual public void Attack(int attackRnd)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The monster used basic attack. You lost " + DamagePerAttack + " health.");
            Console.ResetColor();
            DataStore.Player.CurrentHealth -= DamagePerAttack;
        }
        public override string ToString()
        {
            return $"{Name}\nHP:{Health}/{MaxHealth} {Visuals.ProgressBar(Health, MaxHealth)}";
        }
    }
}