using System;
using System.Collections.Generic;

namespace Adventure
{
    public static class Helpers
    {
        static Random rand = new Random();
        public static double Random(double mean, double stdev)
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
    }
}
