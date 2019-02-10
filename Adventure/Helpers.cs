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

        public static Dictionary<int, int> GetExpForLevel = new Dictionary<int, int>
        {
            { 1,0},
            { 2,5},
            { 3,13},
            { 4,24},
            { 5,41},
            { 6,66},
            { 7,104},
            { 8,161},
            { 9,246},
            { 10,374},
            { 11,567},
            { 12,855},
            { 13,1287},
            { 14,1936},
            { 15,2909},
            { 16,4369},
            { 17,6558},
            { 18,9843},
            { 19,14769},
            { 20,22158},
            { 21,33243},
            { 22,49869},
            { 23,74808},
            { 24,112217},
            { 25,168331},
            { 26,252502},
            { 27,378758}
        };

        public static int GetLevelFromExp(int exp)
        {
            foreach (var level in GetExpForLevel)
            {
                if (exp < level.Value)
                {
                    return level.Key - 1;
                }
            }
            return 10000000;
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
            { 2, new Weapon("Tennis racquet", 3, 30)}
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
            { 0, new Armour("None", 110, 0) },
            { 1, new Armour("Jumper", 1, 10) },
            { 2, new Armour("Cardboard box", 3, 30)}
        };
    }
}
