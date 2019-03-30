using System;

namespace Adventure.Actions
{
    public class ChangeNameAction : IAction
    {
        public string GetText()
        {
            return "Change name";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"What would you like to change your name to? (Input name and press enter)");
            var input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("Name must not be empty!");
                return;
            }
            if (input.Length > 20)
            {
                Console.WriteLine("Name must be 20 characters (including spaces) or less!");
                return;
            }
            player.Name = input;
            Console.WriteLine("Name changed successfully!");
        }
    }
}
