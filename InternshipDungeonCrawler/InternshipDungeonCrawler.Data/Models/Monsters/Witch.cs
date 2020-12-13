using System;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Witch : Monster
    {
        public Witch()
        {
            XpWorth *= 2;
            Name = "witch";
        }
        
        public override void Attack(int attackRnd)
        {
            if (attackRnd < 80)
            {
                base.Attack(attackRnd);
            }
            else
            {
                var rnd = new Random();
                DataStore.ConfuseUsed = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The monster used CONFUSE. Everyone's health is now random");
                Console.ResetColor();
                DataStore.Player.CurrentHealth = (DataStore.Player.CurrentHealth * rnd.Next(1, 100)) / 100;
                DataStore.Enemy.Health = (DataStore.Enemy.Health * rnd.Next(1, 100)) / 100;
            }
        }
    }
}