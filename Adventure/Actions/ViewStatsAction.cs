using System;

namespace Adventure.Actions
{
    public class ViewStatsAction : IAction
    {
        private const int charsToPad = 15;

        public string GetText()
        {
            return "View player stats";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine("PLAYER STATS");
            Console.WriteLine("Name:".PadRight(charsToPad) + player.Name);
            Console.WriteLine("Area:".PadRight(charsToPad) + player.Area + " (of 10)");
            Console.WriteLine("Max hitpoints:".PadRight(charsToPad) + player.MaxHitpoints);
            Console.WriteLine("Hitpoints:".PadRight(charsToPad) + player.Hitpoints);
            Console.WriteLine("Attack:".PadRight(charsToPad) + player.Attack);
            Console.WriteLine("Defense:".PadRight(charsToPad) + player.Defense);
            Console.WriteLine("Weapon:".PadRight(charsToPad) + Helpers.GetWeapon[player.Weapon].Name);
            Console.WriteLine("Armour:".PadRight(charsToPad) + Helpers.GetArmour[player.Armour].Name);
            Console.WriteLine("Gold:".PadRight(charsToPad) + player.Gold);
            Console.WriteLine("Confidence:".PadRight(charsToPad) + player.Confidence);
            Console.WriteLine("Deaths:".PadRight(charsToPad) + player.Deaths);
        }
    }
}
