using InternshipDungeonCrawler.Data;

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

        }
        public static void Brute()
        {

        }
        public static void Witch()
        {

        }
    }
}
