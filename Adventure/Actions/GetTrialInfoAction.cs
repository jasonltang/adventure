using System;

namespace Adventure.Actions
{
    public class GetTrialInfoAction : IAction
    {
        public string GetText()
        {
            return "Get trial info";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            switch (player.Area)
            {
                case 1:
                    Console.WriteLine($"Here's the info for trial 1.");
                    break;
                case 2:
                    Console.WriteLine($"Here's the info for trial 2.");
                    break;
                case 3:
                    Console.WriteLine($"Here's the info for trial 3.");
                    break;
            }
            
        }
    }
}
