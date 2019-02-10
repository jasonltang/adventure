using System;
using Adventure.Locations;

namespace Adventure
{
    public enum TrainingMode
    {
        Hitpoints,
        Attack,
        Defense
    }

    public class Player // Singleton
    {
        private static Player _instance;
        public static Player GetInstance()
        {
            if (_instance == null) _instance = new Player();
            return _instance;
        }
        private Player()
        {
            Name = "Player";
            MaxHitpoints = 10;
            Hitpoints = 10;
            Attack = 1;
            Defense = 1;
            Weapon = 0;
            Armour = 0;
            HitpointsExp = 0;
            AttackExp = 0;
            DefenseExp = 0;
            Gold = 0;
            Confidence = 0;
            Deaths = 0;
            Location = Home.GetInstance();
            ID = Guid.NewGuid();
            Console.WriteLine(Location.LocationText);
        }

        public string Name;
        public int MaxHitpoints;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        public int Weapon;
        public int Armour;
        public int HitpointsExp = 0;
        public int AttackExp = 0;
        public int DefenseExp = 0;
        public TrainingMode TrainingMode = TrainingMode.Hitpoints;
        public int Gold;
        public int Confidence;
        public int Deaths;
        public Location Location { get; set; }
        public Guid ID;
        public Random Rng = new Random((int)DateTime.Now.Ticks);

        public Tuple<string, int> IncrementStat(int amount)
        {
            var statLevelled = "";
            var newLevel = 0;
            switch (TrainingMode)
            {
                case TrainingMode.Hitpoints:
                    HitpointsExp += amount;
                    newLevel = Helpers.GetLevelFromExp(HitpointsExp) * 10;
                    if (newLevel > MaxHitpoints)
                    {
                        MaxHitpoints = newLevel;
                        statLevelled = "Hitpoints";
                    }
                    break;
                case TrainingMode.Attack:
                    AttackExp += amount;
                    newLevel = Helpers.GetLevelFromExp(AttackExp);
                    if (newLevel > Attack)
                    {
                        Attack = newLevel;
                        statLevelled = "Attack";
                    }
                    break;
                case TrainingMode.Defense:
                    DefenseExp += amount;
                    newLevel = Helpers.GetLevelFromExp(DefenseExp);
                    if (newLevel > Defense)
                    {
                        Defense = newLevel;
                        statLevelled = "Defense";
                    }
                    break;
                default:
                    break;
            }
            return new Tuple<string, int>(statLevelled, newLevel);
        }
    }
}
