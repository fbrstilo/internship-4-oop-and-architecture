using System;

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
        public static int Health(int maxHp)
        {
            var rnd = new Random();
            return rnd.Next(1, maxHp);
        }
    }
}
