using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Domain
{
    public class EncounterCalculator
    {
        public int Monster()
        {
            var rnd = new Random();
            return rnd.Next(100);
        }
    }
}
