using System;
using System.Collections.Generic;
using System.Text;

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
                Console.WriteLine("The monster used Charge. You lost " + DamagePerAttack * 2 + " health.");
                Console.ResetColor();
                DataStore.Player.CurrentHealth -= DamagePerAttack * 2;
            }
        }
    }
}
