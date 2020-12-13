using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Player
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; } = 100;
        public int CurrentHealth { get; set; } = 100;
        public int ExperiencePoints { get; set; } = 0;
        public int CurrentLevel { get; set; } = 1;
        public int Damage { get; set; } = 10;
    }
}
