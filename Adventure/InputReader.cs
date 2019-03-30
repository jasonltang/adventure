using System;
using System.Collections.Generic;
using System.Linq;
using Adventure.Actions;

namespace Adventure
{
    public class InputReader
    {
        public static void GetAction(Player player, ref bool lastCommandValid)
        {
            var actionDict = new Dictionary<char, IAction>();
            if (lastCommandValid)
                Console.WriteLine();
            foreach (IAction action in player.Location.AllowedActions)
            {
                char head = action.GetText().First();
                string tail = action.GetText().Remove(0, 1);
                if (lastCommandValid)
                    Console.WriteLine($"[{head}]{tail}");
                actionDict.Add(head, action);
            }
            lastCommandValid = false;
            var input = char.ToUpper(Console.ReadKey(true).KeyChar);
            
            if (actionDict.ContainsKey(input))
            {
                Console.WriteLine(input);
                Console.WriteLine();
                (actionDict[input]).Execute();
                lastCommandValid = true;
                return;
            }
            lastCommandValid = false;
        }
    }
}
