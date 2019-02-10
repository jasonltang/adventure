﻿using System;

namespace Adventure.Actions
{
    public class AboutAction : IAction
    {
        public string GetText()
        {
            return "About this game";
        }

        public void Execute()
        {
            Console.WriteLine("(C) Jason Tang, 2019.");
            Console.WriteLine("This game is a text based RPG based off the old BBS game");
            Console.WriteLine("Legend of the Red Dragon, which was written by Seth Able Robinson in 1989.");
            Console.WriteLine("Use the letter commands to battle monsters and advance through the game.");
            Console.WriteLine("Don't forget to upload your high score!");
            Console.WriteLine("For any feedback, comments or bugs, please email jasonltang@gmail.com.");
        }
    }
}