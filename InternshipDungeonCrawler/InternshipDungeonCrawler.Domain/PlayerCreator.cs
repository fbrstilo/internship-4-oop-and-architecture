using InternshipDungeonCrawler.Data;
using InternshipDungeonCrawler.Data.Models.Player;

namespace InternshipDungeonCrawler.Domain
{
    public static class PlayerCreator
    {
        public static void Warrior(string name)
        {
            DataStore.Player = new Warrior
            {
                Name = name,
                MaxHealth = 75,
                Health = 75,
                Damage = 10
            };
            
        }
        public static void Mage(string name)
        {
            DataStore.Player = new Mage
            {
                Name = name,
                MaxHealth = 35,
                Health = 35,
                Damage = 20
            };
        }
        public static void Ranger(string name)
        {
            DataStore.Player = new Ranger
            {
                Name = name,
                MaxHealth = 50,
                Health = 50,
                Damage = 15
            };
        }
    }
}