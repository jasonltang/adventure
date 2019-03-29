using System;
using System.Collections.Generic;
using System.Linq;
using Adventure.Actions;

namespace Adventure
{
    public class InputReader
    {
        public static void GetAction(Player player)
        {
            var actionDict = new Dictionary<string, IAction>();
            Console.WriteLine();
            foreach (IAction action in player.Location.AllowedActions)
            {
                string head = action.GetText().First().ToString();
                string tail = action.GetText().Remove(0, 1);
                Console.WriteLine($"[{head}]{tail}");
                actionDict.Add(head, action);
            }

            var input = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            if (actionDict.ContainsKey(input))
            {
                (actionDict[input]).Execute();
            }
            else if (player.Location.GetType() == typeof(Locations.Shop))
            {
                ParseShopInput(player, input);
            }
        }

        private static void ParseShopInput(Player player, string input)
        {
            var inputArgs = input.Split(' ');
            if (inputArgs.Length == 2
                && (inputArgs[0] == "W" || inputArgs[0] == "A")
                && int.TryParse(inputArgs[1], out int number))
            {
                if (inputArgs[0] == "W")
                {
                    if (number == 0 || !Helpers.GetWeapon.ContainsKey(number))
                    {
                        Console.WriteLine("We don't have that weapon number.");
                        return;
                    }
                    if (player.Gold < Helpers.GetWeapon[number].Price)
                    {
                        Console.WriteLine("You don't have enough gold for that.");
                        return;
                    }
                    var oldWeapon = player.Weapon;
                    player.Weapon = number;
                    player.Gold -= Helpers.GetWeapon[number].Price;

                    if (oldWeapon == 0)
                    {
                        Console.WriteLine($"You wield the {Helpers.GetWeapon[player.Weapon].Name}!");
                    }
                    else
                    {
                        Console.WriteLine($"You throw out your {Helpers.GetWeapon[oldWeapon].Name} and wield the {Helpers.GetWeapon[player.Weapon].Name}!");
                    }
                }
                else if (inputArgs[0] == "A")
                {
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
                    if (oldArmour == 0)
                    {
                        Console.WriteLine($"You put on the {Helpers.GetArmour[player.Armour].Name}!");
                    }
                    else
                    {
                        Console.WriteLine($"You take off your {Helpers.GetArmour[oldArmour].Name} and put on the {Helpers.GetArmour[player.Armour].Name}!");
                    }
                }
            }
            else
            {
                Console.WriteLine("I don't know what you mean.");
            }
        }
    }
}
