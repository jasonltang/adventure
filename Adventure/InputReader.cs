using System;
using System.Collections.Generic;
using System.Linq;
using Adventure.Actions;

namespace Adventure
{
    public class InputReader
    {
        public static void GetAction(Player player)
        {
            var actionDict = new Dictionary<char, IAction>();
            Console.WriteLine();
            foreach (IAction action in player.Location.AllowedActions)
            {
                char head = action.GetText().First();
                string tail = action.GetText().Remove(0, 1);
                Console.WriteLine($"[{head}]{tail}");
                actionDict.Add(head, action);
            }

            var input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.WriteLine();
            
            if (actionDict.ContainsKey(input))
            {
                (actionDict[input]).Execute();
            }
        }
    }
}
