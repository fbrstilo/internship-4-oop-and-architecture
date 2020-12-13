using System;
using System.Collections.Generic;
using System.Text;
using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Domain
{
    public class PlayerCreator
    {
        public void WarriorCreator(string name)
        {
            var player = new Warrior
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
        }
        public void MageCreator(string name)
        {
            var player = new Mage
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
        }
        public void RangerCreator(string name)
        {
            var player = new Ranger
            {
                Name = name,
                MaxHealth = 200,
                CurrentHealth = 200,
                Damage = 10
            };
        }
    }
}
