using System;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Brute : Monster
    {
        public Brute()
        {
            Health *= 2;
            MaxHealth *= 2;
            DamagePerAttack *= 2;
            XpWorth *=2;
            Name = "brute";
        }

        public override void Attack(int attackRnd)
        {
            if (attackRnd < 6)
            {
                base.Attack(attackRnd);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The monster used CHARGE. You lost " + DamagePerAttack * 15 / 100 + " health.");
                Console.ResetColor();
                DataStore.Player.Health = DataStore.Player.Health * 85/100;
            }
        }
    }
}