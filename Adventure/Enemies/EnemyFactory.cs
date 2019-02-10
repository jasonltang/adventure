using System.Collections.Generic;

namespace Adventure.Enemies
{
    interface IEnemyFactory
    {
        Enemy GetEnemy();
    }

    class EnemyFactory : IEnemyFactory
    {
        ILevelEnemy _generator;
        
        public EnemyFactory()
        {
            if (Player.GetInstance().Location.ToString().Contains("Trial"))
            {
                _generator = new TrialEnemy(Player.GetInstance().Area);
                return;
            }
            switch (Player.GetInstance().Area)
            {
                case 1:
                    _generator = new Level1Enemy();
                    break;
                case 2:
                    _generator = new Level2Enemy();
                    break;
                case 3:
                    _generator = new Level3Enemy();
                    break;
                default:
                    break;
            }
        }

        public Enemy GetEnemy()
        {
            int random = Player.GetInstance().Rng.Next();
            var enemyList = _generator.GetEnemyList();
            return enemyList[random % enemyList.Count];
        }

        interface ILevelEnemy
        {
            List<Enemy> GetEnemyList();
        }

        class Level1Enemy : ILevelEnemy
        {
            public List<Enemy> GetEnemyList()
            {
                return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Rat",
                        hitpoints: 5,
                        attack: 1,
                        defense: 0,
                        weapon: "Big Teeth",
                        victoryText: "Killing the tiny rat really makes you feel tough.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Bird",
                        hitpoints: 2,
                        attack: 1,
                        defense: 0,
                        weapon: "Beak",
                        victoryText: "You pluck the last feather off the bird.",
                        gold: 1,
                        confidence: 1
                    ),
                };
            }
        }

        class Level2Enemy : ILevelEnemy
        {
            public List<Enemy> GetEnemyList()
            {
                return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Rat2",
                        hitpoints: 5,
                        attack: 1,
                        defense: 0,
                        weapon: "Big Teeth",
                        victoryText: "Killing the tiny rat really makes you feel tough.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Bird2",
                        hitpoints: 2,
                        attack: 1,
                        defense: 0,
                        weapon: "Beak",
                        victoryText: "You pluck the last feather off the bird.",
                        gold: 1,
                        confidence: 1
                    ),
                };
            }
        }
        class Level3Enemy : ILevelEnemy
        {
            public List<Enemy> GetEnemyList()
            {
                return new List<Enemy>
                {
                    new Enemy
                    (
                        name: "Rat3",
                        hitpoints: 5,
                        attack: 1,
                        defense: 0,
                        weapon: "Big Teeth",
                        victoryText: "Killing the tiny rat really makes you feel tough.",
                        gold: 2,
                        confidence: 1
                    ),
                    new Enemy
                    (
                        name: "Bird3",
                        hitpoints: 2,
                        attack: 1,
                        defense: 0,
                        weapon: "Beak",
                        victoryText: "You pluck the last feather off the bird.",
                        gold: 1,
                        confidence: 1
                    ),
                };
            }
        }

        class TrialEnemy : ILevelEnemy
        {
            int _area;
            public TrialEnemy(int area)
            {
                _area = area;
            }

            public List<Enemy> GetEnemyList()
            {
                switch (_area)
                {
                    case 1:
                        return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Boss 1",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
                    case 2:
                        return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Boss 2",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
                    case 3:
                        return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Boss 3",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
                    default:
                        return new List<Enemy>
                        {
                            new Enemy
                            (
                                name: "Switch criterion out of bounds.",
                                hitpoints: 5,
                                attack: 1,
                                defense: 0,
                                weapon: "Big Teeth",
                                victoryText: "Killing the tiny rat really makes you feel tough.",
                                gold: 2,
                                confidence: 1
                            )
                        };
                }
            }
        }
    }
}