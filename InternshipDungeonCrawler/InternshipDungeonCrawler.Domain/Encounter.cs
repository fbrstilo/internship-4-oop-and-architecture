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
                Console.Clear();
                MonsterGenerator.Spawn();
                Console.WriteLine("You walk for a bit and encounter a " + DataStore.Enemy.Name
                    + ". They seem eager to fight you.");
                Console.ReadKey();
                while(DataStore.Player.Health>0 && DataStore.Enemy.Health > 0)
                {
                    RockPaperScissorsCombat();
                    DataStore.Player.ToString();
                    DataStore.Enemy.ToString();
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
            var MonsterCombatChoice = (RockPaperScissorsEnum)Randomiser.AttackRnd();
            Console.WriteLine("Choose your attack:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+1 + " - " + (RockPaperScissorsEnum)i);
            }
            var PlayerCombatChoice = (RockPaperScissorsEnum)0;
            var done = false;
            while (!done)
            {
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        done = true;
                        break;
                    case "2":
                        PlayerCombatChoice = (RockPaperScissorsEnum)1;
                        done = true;
                        break;
                    case "3":
                        PlayerCombatChoice = (RockPaperScissorsEnum)2;
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            if ((PlayerCombatChoice == RockPaperScissorsEnum.Rock && MonsterCombatChoice == RockPaperScissorsEnum.Scissors)||(PlayerCombatChoice == RockPaperScissorsEnum.Scissors && MonsterCombatChoice == RockPaperScissorsEnum.Paper)||(PlayerCombatChoice == RockPaperScissorsEnum.Paper && MonsterCombatChoice == RockPaperScissorsEnum.Rock))
            {
                DataStore.Player.Attack();
                Console.ReadKey();
            }
            else if ((PlayerCombatChoice == RockPaperScissorsEnum.Rock && MonsterCombatChoice == RockPaperScissorsEnum.Paper) || (PlayerCombatChoice == RockPaperScissorsEnum.Scissors && MonsterCombatChoice == RockPaperScissorsEnum.Rock) || (PlayerCombatChoice == RockPaperScissorsEnum.Paper && MonsterCombatChoice == RockPaperScissorsEnum.Scissors))
            {
                DataStore.Enemy.Attack(Randomiser.AttackRnd());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A tie! Press any key to continue to next round.");
                Console.ReadKey();
            }
        }
    }
}
