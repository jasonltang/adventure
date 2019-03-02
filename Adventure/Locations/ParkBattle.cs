﻿using System;
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
            return "Search for something to fight";
        }

        public override string LocationText
        {
            get
            {
                int numOptions = 100;
                int rand = _player.Rng.Next();
                if (rand % numOptions > 2)
                {
                    var vowels = new HashSet<char>() { 'A', 'E', 'I', 'O', 'U' };
                    string article = vowels.Contains(_enemy.Name[0]) ? "an" : "a";
                    return "You look for something to kill. \n" +
                        $"You find {article} {_enemy.Name}!\n" +
                        $"\n" +
                        $"Your hitpoints: {_player.Hitpoints}\n" +
                        $"{_enemy.Name}'s hitpoints: {_enemy.Hitpoints}";
                }
                else
                {
                    if (rand % numOptions == 0)
                    {
                        _player.Attack++;
                        Console.WriteLine("You come across a large rock.\n" +
                            "You throw it as far as you can and feel stronger.\n" +
                            $"Attack increased to {_player.Attack}!\n");
                    }
                    else if (rand % numOptions == 1)
                    {
                        _player.Defense++;
                        Console.WriteLine("You come across a large rock.\n" +
                            "It starts rolling towards you and you jump out of the way quickly.\n" +
                            "Defense increased by 1!\n");
                    }
                    else if (rand % numOptions == 2)
                    {
                        _player.MaxHitpoints++;
                        Console.WriteLine("You come across a large rock.\n" +
                            "You take a nap on it and feel refreshed.\n" +
                            "Hitpoints increased by 1!\n");
                    }

                    new ChangeLocationAction(Park.GetInstance()).Execute();
                    return "";
                }
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
