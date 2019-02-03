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
            Console.WriteLine($"Max hitpoints: {player.MaxHitpoints}");
            Console.WriteLine($"Hitpoints: {player.Hitpoints}");
            Console.WriteLine($"Attack: {player.Attack}");
            Console.WriteLine($"Defense: {player.Defense}");
            Console.WriteLine($"Gold: {player.Gold}");
            Console.WriteLine($"Deaths: {player.Deaths}");
        }
    }
}
