using System;

namespace Adventure.Actions.Shop
{
    public class BuyArmourAction : IAction
    {
        public string GetText()
        {
            return "Armour";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"What number armour would you like to buy? (R to return)");
            var input = Console.ReadLine();
            if (input.ToUpper() == "R")
            {
                return;
            }
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("I don't know what you mean.");
                return;
            }
            if (number == 0 || !Helpers.GetArmour.ContainsKey(number))
            {
                Console.WriteLine("We don't have that armour number.");
                return;
            }
            if (player.Gold < Helpers.GetArmour[number].Price)
            {
                Console.WriteLine("You don't have enough gold for that.");
                return;
            }
            var oldArmour = player.Armour;
            player.Armour = number;
            player.Gold -= Helpers.GetArmour[number].Price;
            if (Helpers.GetArmour[oldArmour].Name == "None")
            {
                Console.WriteLine($"You put on the {Helpers.GetArmour[player.Armour].Name}!");
            }
            else
            {
                Console.WriteLine($"You take off your {Helpers.GetArmour[oldArmour].Name} and put on the {Helpers.GetArmour[player.Armour].Name}!");
            }
        }
    }
}
