using System.Collections.Generic;

namespace Adventure.Enemies
{
    interface IEnemyFactory
    {
        Enemy GetEnemy();
    }


    public interface IAreaEnemy
    {
        List<Enemy> GetEnemyList();
    }

    class EnemyFactory : IEnemyFactory
    {
        IAreaEnemy _generator;
        
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
                    _generator = new Area1Enemy();
                    break;
                case 2:
                    _generator = new Area2Enemy();
                    break;
                case 3:
                    _generator = new Area3Enemy();
                    break;
                case 4:
                    _generator = new Area4Enemy();
                    break;
                case 5:
                    _generator = new Area5Enemy();
                    break;
                case 6:
                    _generator = new Area6Enemy();
                    break;
                case 7:
                    _generator = new Area7Enemy();
                    break;
                case 8:
                    _generator = new Area8Enemy();
                    break;
                case 9:
                    _generator = new Area9Enemy();
                    break;
                case 10:
                    _generator = new Area10Enemy();
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
    }
}