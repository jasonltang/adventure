using System;

namespace Adventure.Enemies
{
    public class Enemy
    {
        public Enemy(string name, int hitpoints, int attack, int defense, string weapon, string victoryText, int gold, int confidence)
        {
            Name = name;
            Hitpoints = hitpoints;
            Attack = attack;
            AttackStdev = Convert.ToInt32(Math.Sqrt(attack));
            Defense = defense;
            Weapon = weapon;
            VictoryText = victoryText;
            Gold = gold;
            Confidence = confidence;

        }

        public Enemy(string name, int hitpoints, int attack, int attackStdev, int defense, string weapon, string victoryText, int gold, int confidence)
        {
            Name = name;
            Hitpoints = hitpoints;
            Attack = attack;
            AttackStdev = attackStdev;
            Defense = defense;
            Weapon = weapon;
            VictoryText = victoryText;
            Gold = gold;
            Confidence = confidence;
        }

        public string Name { get; }
        public int Hitpoints { get; set; }
        public int Attack { get; }
        public int AttackStdev { get; }
        public int Defense { get; }
        public string Weapon { get; }
        public string VictoryText { get; }
        public int Gold { get; }
        public int Confidence { get; }
    }
}
