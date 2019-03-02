using System;
using System.Collections.Generic;

namespace Adventure
{
    public static class Helpers
    {
        static Random rand = new Random();
        public static double RandomNormal(double mean, double stdev)
        {
            double u1 = 1.0 - rand.NextDouble();
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2);
            return mean + stdev * randStdNormal;
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
            { 0, new Weapon("None", 0, 0) },
            { 1, new Weapon("Chopstick", 1, 10) },
            { 2, new Weapon("Tennis racquet", 2, 20)},
            { 3, new Weapon("Baseball bat", 4, 50)},

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
            { 0, new Armour("None", 0, 0) },
            { 1, new Armour("Jumper", 1, 10) },
            { 2, new Armour("Cardboard box", 2, 20)},
            { 3, new Armour("Leather vest", 4, 50)},

        };

        public static Dictionary<int, int> GetHitpointsByArea = new Dictionary<int, int>
        {
            { 1, 10 },
            { 2, 30 },
            { 3, 70 },
        };
    }
}
