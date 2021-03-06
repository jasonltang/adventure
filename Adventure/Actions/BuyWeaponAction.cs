﻿using System;

namespace Adventure.Actions
{
    public class BuyWeaponAction : IAction
    {
        public string GetText()
        {
            return "Weapon";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"What number weapon would you like to buy? (Input number and press enter)");
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
            if (number == player.Weapon)
            {
                Console.WriteLine("That's the same weapon you already have!");
                return;
            }
            if (number < player.Weapon)
            {
                Console.WriteLine("Sorry, we can't let you downgrade your weapon.");
                return;
            }
            var oldWeapon = player.Weapon;
            player.Weapon = number;
            player.Gold -= Helpers.GetWeapon[number].Price;
            Console.WriteLine($"You throw out your {Helpers.GetWeapon[oldWeapon].Name} and wield the {Helpers.GetWeapon[player.Weapon].Name}!");
        }
    }
}