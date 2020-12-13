using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models;
using InternshipDungeonCrawler.Data.Models.Player;
using System;

namespace InternshipDungeonCrawler.Domain
{
    public static class Leveling
    {
        public static void NextLevel()
        {
            DataStore.Player.ExperiencePoints += DataStore.Enemy.XpWorth;
            while (DataStore.Player.ExperiencePoints >= 10 * DataStore.Player.CurrentLevel)
            {
                DataStore.Player.ExperiencePoints -= 10 * DataStore.Player.CurrentLevel;
                DataStore.Player.CurrentLevel++;
                DataStore.Player.NextLevel();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You have leveled up!");
                Console.ResetColor();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            Console.WriteLine("XP:" +  DataStore.Player.ExperiencePoints +"/" +  10 * DataStore.Player.CurrentLevel + 
             Visuals.ProgressBar(DataStore.Player.ExperiencePoints, 10 * DataStore.Player.CurrentLevel));

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}
