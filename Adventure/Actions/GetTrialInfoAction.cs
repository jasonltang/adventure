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
                    Console.WriteLine($"Salespeople are very resilient,\n" +
                        $"so it will take a lot of persistence to bring one down.");
                    break;
                case 2:
                    Console.WriteLine($"Jane Goodall is one of the leading experts on chimpanzees.\n" +
                        $"You will need well balanced stats to defeat her.");
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
