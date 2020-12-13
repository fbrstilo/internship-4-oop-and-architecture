using InternshipDungeonCrawler.Data.Models.Monsters;
using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Data
{
    public static class DataStore
    {
        public static int EncounterCount { get; set; } = 1;
        public static Player Player { get; set; }
        public static Monster Enemy { get; set; }
        public static bool ConfuseUsed { get; set; } = false;
        public static int PauseEncounterCount { get; set; } = 0;
    }
}
