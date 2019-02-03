using System;
using System.Collections.Generic;
using System.Linq;
using Adventure.Actions;

namespace Adventure
{
    class InputReader
    {
        public static void GetAction(Player player)
        {
            var actionDict = new Dictionary<string, IAction>();
            Console.WriteLine();
            foreach (IAction action in player.Location.AllowedActions)
            {
                string head = action.GetText().First().ToString();
                string tail = action.GetText().Remove(0, 1);
                Console.WriteLine($"[{head}]{tail}");
                actionDict.Add(head, action);
            }

            var input = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            if(actionDict.ContainsKey(input))
            {
                (actionDict[input]).Execute();
            }
        }
    }
}
