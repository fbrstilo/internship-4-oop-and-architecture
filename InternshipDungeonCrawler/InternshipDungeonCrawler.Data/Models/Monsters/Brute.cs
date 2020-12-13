using System;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Brute : Monster
    {
        public Brute()
        {
            Health = Health * 2;
            DamagePerAttack = DamagePerAttack * 2;
            XpWorth = XpWorth * 2;
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
                DataStore.Player.CurrentHealth = DataStore.Player.CurrentHealth * 85/100;
            }
        }
    }
}
