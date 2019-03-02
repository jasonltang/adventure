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
                case 4:
                    Console.WriteLine($"Here's the info for trial 4.");
                    break;
                case 5:
                    Console.WriteLine($"Here's the info for trial 5.");
                    break;
                case 6:
                    Console.WriteLine($"Here's the info for trial 6.");
                    break;
                case 7:
                    Console.WriteLine($"Here's the info for trial 7.");
                    break;
                case 8:
                    Console.WriteLine($"Here's the info for trial 8.");
                    break;
                case 9:
                    Console.WriteLine($"Here's the info for trial 9.");
                    break;
                case 10:
                    Console.WriteLine($"Here's the info for trial 10.");
                    break;
            }
            
        }
    }
}
