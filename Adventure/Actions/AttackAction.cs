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
                Console.WriteLine($"You receive {_enemy.Gold} gold.");
                _player.Gold += _enemy.Gold;
                Console.WriteLine();
                new ChangeLocationAction(Park.GetInstance()).Execute();
                return;
            }
            EnemyAttackPlayer();
            if (IsPlayerDead())
            {
                Console.WriteLine("You die!");
                Console.WriteLine();
                _player.Deaths++;
                _player.Hitpoints = _player.MaxHitpoints;
                new ChangeLocationAction(Home.GetInstance()).Execute();
                return;
            }
            PrintDialogue();
        }

        private void PlayerAttackEnemy()
        {
            var attackDamage = Math.Max(0, _player.Attack - _enemy.Defense);
            _enemy.Hitpoints -= attackDamage;
            Console.WriteLine($"You hit {_enemy.Name} for {attackDamage} damage!");
        }

        private bool IsEnemyDead()
        {
            return _enemy.Hitpoints <= 0;
        }

        private void EnemyAttackPlayer()
        {
            var attackDamage = Math.Max(0, _enemy.Attack - _player.Defense);
            _player.Hitpoints -= attackDamage;
            Console.WriteLine($"{_enemy.Name} hits you for {attackDamage} damage!");
        }

        private bool IsPlayerDead()
        {
            return _player.Hitpoints <= 0;
        }

        private void PrintDialogue()
        {
            Console.WriteLine();
            Console.WriteLine($"{_enemy.Name}'s hitpoints: {_enemy.Hitpoints}");
            Console.WriteLine($"Your hitpoints: { _player.Hitpoints }");
        }
    }
}
