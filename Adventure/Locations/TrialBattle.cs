using System.Collections.Generic;
using Adventure.Actions;
using Adventure.Enemies;

namespace Adventure.Locations
{
    class TrialBattle : Location
    {
        public TrialBattle()
        {
            _player = Player.GetInstance();
            IEnemyFactory enemyFactory = new EnemyFactory();
            _enemy = enemyFactory.GetEnemy();
        }
        private Enemy _enemy;
        private Player _player;

        public override string GetText()
        {
            return "Start trial battle";
        }

        public override string LocationText
        {
            get
            {
                return $"You start a battle with {_enemy.Name}!\n" +
                    $"\n" +
                    $"Your hitpoints: {_player.Hitpoints}\n" +
                    $"{_enemy.Name}'s hitpoints: {_enemy.Hitpoints}";                    ;
            }
        }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new AttackAction(_enemy),
                    new RunAction("Trial"),
                    new ViewStatsAction()
                };
            }
        }
    }
}
