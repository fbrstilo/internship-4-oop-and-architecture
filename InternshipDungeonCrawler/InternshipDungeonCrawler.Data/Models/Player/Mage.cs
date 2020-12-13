using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Mage : Player
    {
        public Mage()
        {
            Damage = Damage * 3;
        }
        public int CurrentMana { get; set; }
        public int MaxMana { get; set; }
    }
}
