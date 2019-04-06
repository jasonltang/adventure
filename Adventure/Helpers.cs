using System;
using System.Collections.Generic;

namespace Adventure
{
    public static class Helpers
    {
        static Random rand = new Random();

        /// <summary>
        /// Returns a gaussian random variable.
        /// </summary>
        /// <param name="mean"></param>
        /// <param name="stDev">Must be non-negative.</param>
        /// <returns></returns>
        public static double RandomNormal(double mean, double stDev)
        {
            if (stDev < 0) throw new ArgumentException("Standard deviation cannot be less than 0!");
            double u1 = 1.0 - rand.NextDouble();
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2);
            return mean + stDev * randStdNormal;
        }

        public class Weapon
        {
            public Weapon(string name, int attack, int price)
            {
                Name = name;
                Attack = attack;
                Price = price;
            }

            public string Name;
            public int Attack;
            public int Price;
        }

        public static Dictionary<int, Weapon> GetWeapon = new Dictionary<int, Weapon>
        {
            { 0, new Weapon("Fists", 0, 0) },
            { 1, new Weapon("Chopstick", 1, 10) },
            { 2, new Weapon("Empty Beer Bottle", 2, 40)},
            { 3, new Weapon("Baseball Bat", 4, 130)},
            { 4, new Weapon("Dagger", 7, 250)},
            { 5, new Weapon("Sword", 15, 400)},
            { 6, new Weapon("Pen", 32, 1000)},
            { 7, new Weapon("Chainsaw", 52, 3000)},
            { 8, new Weapon("Shotgun", 80, 10000)},
            { 9, new Weapon("Laser", 130, 20000)},
            { 10, new Weapon("Flamethrower", 200, 35000)},
            { 11, new Weapon("Thor's Hammer", 300, 60000)},
            { 12, new Weapon("Elder Wand", 400, 100000)},

        };

        public class Armour
        {
            public Armour(string name, int defense, int price)
            {
                Name = name;
                Defense = defense;
                Price = price;
            }

            public string Name;
            public int Defense;
            public int Price;
        }

        public static Dictionary<int, Armour> GetArmour = new Dictionary<int, Armour>
        {
            { 0, new Armour("Birthday Suit", 0, 0) },
            { 1, new Armour("Jumper", 1, 10) },
            { 2, new Armour("Cardboard Box", 2, 40)},
            { 3, new Armour("Hi-Vis Vest", 4, 130)},
            { 4, new Armour("Leather Jacket", 7, 250)},
            { 5, new Armour("Bulletproof Vest", 15, 400)},
            { 6, new Armour("Gladiator Armour", 32, 1000)},
            { 7, new Armour("Iron Man Suit", 52, 3000)},
            { 8, new Armour("Shield of Sand", 80, 10000)},
            { 9, new Armour("Forcefield", 130, 20000)},
            { 10, new Armour("Protection Bubble", 200, 35000)},
            { 11, new Armour("Nautilus", 300, 60000)},
            { 12, new Armour("Seldon Plan", 400, 100000)},

        };

        public static int ModifyGold(int baseGold)
        {
            var gameCompletions = Player.GetInstance().GameCompletions;
            var multiplier = Math.Pow(1.1, gameCompletions);
            return (int)Math.Floor(baseGold * multiplier);
        }

        public static ConsoleColor GetTextColourByArea(int area)
        {
            switch (area)
            {
                case 1:
                    return ConsoleColor.DarkGreen;
                case 2:
                    return ConsoleColor.DarkCyan;
                case 3:
                    return ConsoleColor.Gray;
                case 4:
                    return ConsoleColor.DarkYellow;
                case 5:
                    return ConsoleColor.DarkRed;
                default:
                    return ConsoleColor.Black;
            }
        }
    }
}
