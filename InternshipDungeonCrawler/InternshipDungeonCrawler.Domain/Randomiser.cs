using System;
using System.Collections.Generic;
using System.Text;

namespace InternshipDungeonCrawler.Domain
{
    public static class Randomiser
    {
        public static int Monster()
        {
            var rnd = new Random();
            return rnd.Next(100);
        }
        public static int AttackRnd()
        {
            var rnd = new Random();
            return rnd.Next(10);
        }
    }
}
