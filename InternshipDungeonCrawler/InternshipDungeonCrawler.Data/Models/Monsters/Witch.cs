using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Witch : Monster
    {
        public Witch()
        {
            XpWorth = XpWorth * 2;
        }
        public override void Attack(int attackRnd)
        {
            if (attackRnd < 80)
            {
                base.Attack(attackRnd);
            }
            else
            {
                Console.WriteLine("The monster used CONFUSE. Everyone's health is now random");
            }
        }
    }
}
