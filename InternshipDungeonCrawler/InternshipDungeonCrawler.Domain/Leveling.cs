using System;
using System.Collections.Generic;
using System.Text;
using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models;

namespace InternshipDungeonCrawler.Domain
{
    public class Leveling
    {
        public Tuple<int,int> LevelProgress(int gainedxp,int currentxp)
        {
            var levelupThreshold = 10 * DataStore.EncounterCount;
            while(currentxp + gainedxp >= levelupThreshold)
            {
                Player.CurrentLevel += 1;
                currentxp -= levelupThreshold;
            }
            return new Tuple<int, int>(currentlevel, currentxp);
        }
    }
}
