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
                MaxHealth = 200,
                Health = 200,
                Damage = 10
            };
            
        }
        public static void Mage(string name)
        {
            DataStore.Player = new Mage
            {
                Name = name,
                MaxHealth = 200,
                Health = 200,
                Damage = 10
            };
        }
        public static void Ranger(string name)
        {
            DataStore.Player = new Ranger
            {
                Name = name,
                MaxHealth = 200,
                Health = 200,
                Damage = 10
            };
        }
    }
}