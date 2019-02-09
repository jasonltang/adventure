using System;

namespace Adventure.Actions
{
    public class ChangeTrainingModeAction : IAction
    {
        public string GetText()
        {
            return "Train a different stat";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            Console.WriteLine($"You are currently training {player.TrainingMode}.");
            Console.WriteLine($"What stat would you like to train instead? (H)itpoints / (A)ttack / (Defense)");
            var input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("You didn't type anything.");
                return;
            }
            if (char.ToUpper(input[0]) == 'H')
            {
                player.TrainingMode = TrainingMode.Hitpoints;
                Console.WriteLine("You will now train the Hitpoints stat.");
                return;
            }
            if (char.ToUpper(input[0]) == 'A')
            {
                player.TrainingMode = TrainingMode.Attack;
                Console.WriteLine("You will now train the Attack stat.");
                return;
            }
            if (char.ToUpper(input[0]) == 'D')
            {
                player.TrainingMode = TrainingMode.Defense;
                Console.WriteLine("You will now train the Defense stat.");
                return;
            }
            Console.WriteLine("Couldn't understand which stat.");
        }
    }
}
