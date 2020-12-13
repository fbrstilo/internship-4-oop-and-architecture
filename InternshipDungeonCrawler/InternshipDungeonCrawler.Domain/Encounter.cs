using System;
using System.Collections.Generic;
using System.Text;
using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models.Monsters;
using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Domain
{
    public static class Encounter
    {
        public static void NewEncounter()
        {
            while (DataStore.EncounterCount <= 10)
            {
                MonsterGenerator.Spawn();
                Console.WriteLine("You walk for a bit and encounter a " + DataStore.Enemy.Name);
                while(DataStore.Player.Health>0 && DataStore.Enemy.Health > 0)
                {
                    RockPaperScissorsCombat();
                }
                if (DataStore.Player.Health <= 0)
                {
                    Console.Clear();
                    Menus.DeathScreen();
                }
                else if (DataStore.Enemy.Health <= 0)
                {
                    Console.WriteLine("You have killed the " + DataStore.Enemy.Name);
                    if(DataStore.Enemy is Witch)
                    {
                        Console.WriteLine("With her last breath the witch spawned 2 more enemies");
                        DataStore.PauseEncounterCount += 2;
                    }
                    Leveling.NextLevel();
                    Player.Regen();
                    if (DataStore.Player.Health < DataStore.Player.MaxHealth && DataStore.Player.ExperiencePoints>1)
                    {
                        Console.WriteLine("Press 1 if you would like to fully heal before the next encounter (cost: 50% of current xp)");
                        var userInput = Console.ReadLine();
                        if (userInput == "1")
                        {
                            DataStore.Player.ExperiencePoints = (int)(0.5 * DataStore.Player.ExperiencePoints);
                        }
                    }
                }
                if (DataStore.PauseEncounterCount != 0)
                {
                    DataStore.PauseEncounterCount--;
                }
                else
                {
                    DataStore.EncounterCount++;
                }
            }
        }
        private static void RockPaperScissorsCombat()
        {

        }
    }
}
