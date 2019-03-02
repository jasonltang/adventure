using System.Collections.Generic;
using Adventure.Actions;
using Adventure.Enemies;

namespace Adventure.Locations
{
    class ParkBattle : Location
    {
        public ParkBattle()
        {
            _player = Player.GetInstance();
            IEnemyFactory enemyFactory = new EnemyFactory();
            _enemy = enemyFactory.GetEnemy();
        }
        private Enemy _enemy;
        private Player _player;

        public override string GetText()
        {
            return "Look for something to kill";
        }

        public override string LocationText
        {
            get
            {
                var vowels = new HashSet<char>() { 'A', 'E', 'I', 'O', 'U' };
                string article =  vowels.Contains(_enemy.Name[0]) ? "an" : "a";
                return "You look for something to kill. \n" +
                    $"You find {article} {_enemy.Name}!\n" +
                    $"\n" +
                    $"{_enemy.Name}'s hitpoints: {_enemy.Hitpoints}\n" +
                    $"Your hitpoints: {_player.Hitpoints}";
            }
        }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new AttackAction(_enemy),
                    new RunAction("Park"),
                    new ViewStatsAction()
                };
            }
        }
    }
}
