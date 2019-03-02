using System;
using Adventure.Enemies;
using Adventure.Locations;

namespace Adventure.Actions
{
    public class AttackAction : IAction
    {
        public AttackAction(Enemy enemy)
        {
            _enemy = enemy;
        }

        private Enemy _enemy;
        private Player _player = Player.GetInstance();

        public string GetText()
        {
            return "Attack";
        }

        public void Execute()
        {
            PlayerAttackEnemy();
            if (IsEnemyDead())
            {
                Console.WriteLine($"You have killed the {_enemy.Name}!");
                Console.WriteLine(_enemy.VictoryText);
                Console.WriteLine($"You gain {_enemy.Gold} gold and {_enemy.Confidence} confidence.");
                _player.Gold += _enemy.Gold;
                _player.Confidence += _enemy.Confidence;
                Console.WriteLine();
                PostBattleActions();
                return;
            }
            EnemyAttackPlayer();
            if (IsPlayerDead())
            {
                Console.WriteLine("You die and lose 10% of your confidence!");
                Console.WriteLine();
                _player.Deaths++;
                _player.Hitpoints = _player.MaxHitpoints;
                _player.Confidence = (int)(0.9 * _player.Confidence);
                new ChangeLocationAction(Home.GetInstance()).Execute();
                return;
            }
            PrintDialogue();
        }

        private void PlayerAttackEnemy()
        {
            int totalAttack = _player.Attack + Helpers.GetWeapon[_player.Weapon].Attack;
            var attackDamage = Math.Max(
                0,
                Convert.ToInt32(
                    Helpers.RandomNormal(
                        totalAttack,
                        Math.Sqrt(totalAttack)))
                    - _enemy.Defense);
            _enemy.Hitpoints -= attackDamage;
            if (attackDamage == 0)
            {
                Console.WriteLine("You miss completely!");
                return;
            }
            Console.WriteLine($"You hit {_enemy.Name} for {attackDamage} damage!");
        }

        private bool IsEnemyDead()
        {
            return _enemy.Hitpoints <= 0;
        }

        private void EnemyAttackPlayer()
        {
            var attackDamage = Math.Max(
                0,
                (int)Math.Round(Helpers.RandomNormal(_enemy.Attack, _enemy.AttackStdev))
                    - (_player.Defense + Helpers.GetArmour[_player.Armour].Defense));
            _player.Hitpoints -= attackDamage;
            if (attackDamage == 0)
            {
                Console.WriteLine($"{_enemy.Name} misses completely!");
                return;
            }
            Console.WriteLine($"{_enemy.Name} hits you with its {_enemy.Weapon} for {attackDamage} damage!");
        }

        private bool IsPlayerDead()
        {
            return _player.Hitpoints <= 0;
        }

        private void PrintDialogue()
        {
            Console.WriteLine();
            Console.WriteLine($"Your hitpoints: { _player.Hitpoints }");
            Console.WriteLine($"{_enemy.Name}'s hitpoints: {_enemy.Hitpoints}");
        }

        private void PostBattleActions()
        {
            if (_player.Location.ToString().Contains("ParkBattle"))
            {
                new ChangeLocationAction(Park.GetInstance()).Execute();
            }
            else if (_player.Location.ToString().Contains("TrialBattle"))
            {
                if (_player.Area != 10)
                {
                    _player.Area++;
                    _player.MaxHitpoints = Helpers.GetHitpointsByArea[_player.Area];
                    Console.WriteLine($"Congratulations! You have advanced to area {_player.Area}!");
                    Console.WriteLine($"Your max hitpoints increases to {_player.Hitpoints}.");
                    Console.WriteLine($"You wonder how your confidence rates on the high score list now.");
                    Console.WriteLine($"This area contains stronger enemies.");
                    _player.Hitpoints = _player.MaxHitpoints;
                    new ChangeLocationAction(Home.GetInstance()).Execute();
                }
                else
                {
                    _player.Reset();
                    int confidenceBonus = 1000;
                    _player.Confidence += confidenceBonus;
                    Console.WriteLine($"You have beaten the final boss! You gain {confidenceBonus} confidence and you have been returned to area 1 to start the journey again.");
                }
            }
        }
    }
}
