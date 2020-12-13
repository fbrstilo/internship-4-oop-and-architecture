using InternshipDungeonCrawler.Data;

namespace InternshipDungeonCrawler.Domain
{
    public class Leveling
    {
        public int LevelProgress(int gainedxp)
        {
            var levelupThreshold = 10 * DataStore.Player.CurrentLevel;
            while(DataStore.Player.ExperiencePoints + gainedxp >= levelupThreshold)
            {
                DataStore.Player.CurrentLevel += 1;
                DataStore.Player.ExperiencePoints -= levelupThreshold;
            }
            return levelupThreshold - DataStore.Player.ExperiencePoints;
        }
    }
}
