using System;

namespace Adventure.Actions
{
    public class ViewStatsAction : IAction
    {
        public string GetText()
        {
            return "View player stats";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"PLAYER STATS");
            Console.WriteLine($"Name: {player.Name}");
            Console.WriteLine($"Max hitpoints: {player.MaxHitpoints} " +
                $"(Current exp {player.HitpointsExp}, next level at {Helpers.GetExpForLevel[player.MaxHitpoints/10 + 1]})");
            Console.WriteLine($"Hitpoints: {player.Hitpoints}");
            Console.WriteLine($"Attack: {player.Attack} " +
                $"(Current exp {player.AttackExp}, next level at {Helpers.GetExpForLevel[player.Attack + 1]})");
            Console.WriteLine($"Defense: {player.Defense} " +
                $"(Current exp {player.DefenseExp}, next level at {Helpers.GetExpForLevel[player.Defense + 1]})");
            Console.WriteLine($"Weapon: {Helpers.GetWeapon[player.Weapon].Name}");
            Console.WriteLine($"Armour: {Helpers.GetArmour[player.Armour].Name}");
            Console.WriteLine($"Training mode: {player.TrainingMode}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Confidence: {player.Confidence}");
            Console.WriteLine($"Deaths: {player.Deaths}");
        }
    }
}
