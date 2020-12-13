using System;
using InternshipDungeonCrawler.Data.Models.Monsters;

namespace InternshipDungeonCrawler.Data.Models.Player
{
    public class Player
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; } = 50;
        public int Health { get; set; } = 50;
        public int ExperiencePoints { get; set; } = 0;
        public int CurrentLevel { get; set; } = 1;
        public int Damage { get; set; } = 10;


        virtual public void NextLevel()
        {
            DataStore.Player.MaxHealth *= 2;
            DataStore.Player.Health = DataStore.Player.MaxHealth;
            DataStore.Player.Damage *= 2;
        }
        public static void Regen()
        {
            if (DataStore.Player.Health < DataStore.Player.MaxHealth && (DataStore.Player.MaxHealth - DataStore.Player.Health)<(int)(DataStore.Player.MaxHealth * 0.25))
            {
                Console.WriteLine("You have healed for " + (int)(DataStore.Player.MaxHealth * 0.25) + " health points.\n");
                DataStore.Player.Health += (int)(DataStore.Player.MaxHealth * 0.25);
                Console.WriteLine("Current HP: " + DataStore.Player.Health);
            }
        }
        public static void ExperienceHeal()
        {
            DataStore.Player.ExperiencePoints = (int)0.5 * DataStore.Player.ExperiencePoints;
            DataStore.Player.Health = DataStore.Player.MaxHealth;
            Console.WriteLine("You are now at full health.");
        }
        virtual public void Attack()
        {
            DataStore.Enemy.Health -= DataStore.Player.Damage;
            Console.WriteLine("You attacked the " + DataStore.Enemy.Name + " and caused " + DataStore.Player.Damage + " damage points");
        }
        public override string ToString()
        {
            return $"{Name}\nHP:{Health}/{MaxHealth} {Visuals.ProgressBar(Health, MaxHealth)}\nXP:{ExperiencePoints}/{10*CurrentLevel} {Visuals.ProgressBar(ExperiencePoints, 10*CurrentLevel)}";
        }
    }
}