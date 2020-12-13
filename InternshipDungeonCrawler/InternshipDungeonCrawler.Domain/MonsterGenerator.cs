using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models.Monsters;

namespace InternshipDungeonCrawler.Domain
{
    class MonsterGenerator
    {
        public static void Spawn()
        {
            var ranInt = Randomiser.Monster();
            if(ranInt < 60)
            {
                Goblin();
            }
            else if (ranInt < 90)
            {
                Brute();
            }
            else
            {
                Witch();
            }
            if(DataStore.ConfuseUsed == true)
            {
                DataStore.Enemy.Health = Randomiser.Health(DataStore.Enemy.Health);
            }
        }
        public static void Goblin()
        {
            DataStore.Enemy = new Goblin { };
            
        }
        public static void Brute()
        {
            DataStore.Enemy = new Brute { };
        }
        public static void Witch()
        {
            DataStore.Enemy = new Witch { };
        }
    }
}