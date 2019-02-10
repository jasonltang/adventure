﻿using System;
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
                Console.WriteLine($"You gain some {_player.TrainingMode.ToString()} exp.");
                _player.Gold += _enemy.Gold;
                _player.Confidence += _enemy.Confidence;
                var incrementedStatAndLevel = _player.IncrementStat(_enemy.Confidence);
                if (!string.IsNullOrEmpty(incrementedStatAndLevel.Item1))
                {
                    Console.WriteLine($"Congratulations! Your {incrementedStatAndLevel.Item1} stat increased to level {incrementedStatAndLevel.Item2}.");
                }
                Console.WriteLine();
                new ChangeLocationAction(Park.GetInstance()).Execute();
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
            var attackDamage = Math.Max(
                0,
                (int)Math.Round(
                    Helpers.RandomNormal(
                        _player.Attack + Helpers.GetWeapon[_player.Weapon].Attack,
                        _player.Attack + Helpers.GetWeapon[_player.Weapon].Attack))
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
                (int)Math.Round(Helpers.RandomNormal(_enemy.Attack, _enemy.Attack))
                    - (_player.Defense + Helpers.GetArmour[_player.Armour].Defense));
            _player.Hitpoints -= attackDamage;
            if (attackDamage == 0)
            {
                Console.WriteLine($"{_enemy.Name} misses completely!");
                return;
            }
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
