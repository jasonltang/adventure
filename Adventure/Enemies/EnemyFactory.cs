using System.Collections.Generic;

namespace Adventure.Enemies
{
    interface IEnemyFactory
    {
        Enemy GetEnemy();
    }

    struct EnemyStruct
    {
        public string Name;
        public int Hitpoints;
        public int Attack;
        public int Defense;
        public string VictoryText;
        public int Gold;
        public int Confidence;
    }

    class EnemyFactory : IEnemyFactory
    {
        public Enemy GetEnemy()
        {
            int random = Player.GetInstance().Rng.Next();
            var enemy = enemyList[random % enemyList.Count];
            return new Enemy(enemy.Name, enemy.Hitpoints, enemy.Attack, enemy.Defense, enemy.VictoryText, enemy.Gold, enemy.Confidence);
        }

        List<EnemyStruct> enemyList = new List<EnemyStruct>()
        {
            new EnemyStruct
            {
                Name = "Rat",
                Hitpoints = 5,
                Attack = 1,
                Defense = 0,
                VictoryText = "Killing the tiny rat really makes you feel tough.",
                Gold = 2,
                Confidence = 1,
            },
            new EnemyStruct
            {
                Name = "Bird",
                Hitpoints = 2,
                Attack = 1,
                Defense = 0,
                VictoryText = "You pluck the last feather off the bird.",
                Gold = 1,
                Confidence = 1,
            },
        };
    }
}
