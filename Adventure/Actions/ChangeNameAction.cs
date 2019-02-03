using System;

namespace Adventure.Actions
{
    public class ChangeNameAction : IAction
    {
        public string GetText()
        {
            return "Change Name";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"What would you like to change your name to?");
            var input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("Name must not be empty!");
                return;
            }
            player.Name = input;
            Console.WriteLine("Name changed successfully!");
        }
    }
}
