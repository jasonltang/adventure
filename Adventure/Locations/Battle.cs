﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Actions;
using Adventure.Enemies;

namespace Adventure.Locations
{
    class Battle : Location
    {
        //private static Battle _instance;
        //public static Battle GetInstance()
        //{
        //    if (_instance == null) _instance = new Battle();
        //    return _instance;
        //}
        //private Battle()
        //{

        //}

        private Enemy _enemy = new Rat(); // Change to enemyFactory
        private Player _player = Player.GetInstance();

        public override string LocationText
        {
            get
            {
                return "You look for something to kill. \n" +
                    $"You find a {_enemy.Name}!\n" +
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
                    new RunAction(),
                    new ViewStatsAction()
                };
            }
        }
    }
}