using System;
using System.Collections.Generic;
using System.Text;
using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Domain
{
    public static class PlayerCreator
    {
        public static void WarriorCreator(string name)
        {
            DataStore.player = new Warrior
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
            
        }
        public static void MageCreator(string name)
        {
            DataStore.player = new Mage
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
        }
        public static void RangerCreator(string name)
        {
            DataStore.player = new Ranger
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
        }
    }
}
