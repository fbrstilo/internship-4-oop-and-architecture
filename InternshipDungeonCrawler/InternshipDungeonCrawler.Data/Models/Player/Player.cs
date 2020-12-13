using System;
using InternshipDungeonCrawler.Data.Models.Monsters;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Player
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; } = 50;
        public int CurrentHealth { get; set; } = 50;
        public int ExperiencePoints { get; set; } = 0;
        public int CurrentLevel { get; set; } = 1;
        public int Damage { get; set; } = 10;

        public void HealthRegen(Player Player)
        {
            if (Player.CurrentHealth < Player.MaxHealth && (Player.MaxHealth - Player.CurrentHealth)<(int)(Player.MaxHealth * 0.25))
            {
                Console.WriteLine("You have healed for " + (int)(Player.MaxHealth * 0.25) + " health points.\n");
                Player.CurrentHealth += (int)(Player.MaxHealth * 0.25);
                Console.WriteLine("Current HP: " + Player.CurrentHealth);
            }
        }
        public void ExperienceHeal(Player Player)
        {
            Player.ExperiencePoints = (int)0.5 * Player.ExperiencePoints;
            Player.CurrentHealth = Player.MaxHealth;
            Console.WriteLine("You are now at full health.");
        }
        virtual public void Attack(Player Player, Monster Enemy)
        {
            Enemy.Health -= Player.Damage;
            Console.WriteLine("You attacked the " + Enemy.Name + " and caused " + Player.Damage + " damage points");
        }
    }
}