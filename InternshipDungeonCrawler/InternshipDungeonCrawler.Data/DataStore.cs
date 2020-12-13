using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Data
{
    public static class DataStore
    {
        public static int EncounterCount { get; set; } = 1;
        public static Player player { get; set; }
    }
}
