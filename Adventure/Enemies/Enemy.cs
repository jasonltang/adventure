namespace Adventure.Enemies
{
    public class Enemy
    {
        public Enemy(string name, int hitpoints, int attack, int defense, string victoryText, int gold, int confidence)
        {
            Name = name;
            Hitpoints = hitpoints;
            Attack = attack;
            Defense = defense;
            VictoryText = victoryText;
            Gold = gold;
            Confidence = confidence;
        }

        public string Name { get; }
        public int Hitpoints { get; set; }
        public int Attack { get; }
        public int Defense { get; }
        public string VictoryText { get; }
        public int Gold { get; }
        public int Confidence { get; }
    }
}
