using System;
using System.Collections.Generic;
using System.Text;
using InternshipDungeonCrawler.Data;

namespace InternshipDungeonCrawler.Data.Models.Monsters
{
    public class Monster
    {
        public int Health { get; set; } = 10 * DataStore.EncounterCount;
        public int DamagePerAttack { get; set; } = 10 * DataStore.EncounterCount;
        public int XpWorth { get; set; } = 10 * DataStore.EncounterCount;
    }
}
