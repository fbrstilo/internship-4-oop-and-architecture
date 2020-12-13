using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Warrior : Player
    {
        public Warrior()
        {
            MaxHealth = MaxHealth * 3;
        }
    }
}
