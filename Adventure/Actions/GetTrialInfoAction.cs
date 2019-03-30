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
                    Console.WriteLine($"Elephants have high health,\n" +
                        $"so make sure you can hit it hard.");
                    break;
                case 2:
                    Console.WriteLine($"Jane Goodall is one of the leading experts on chimpanzees.\n" +
                        $"You will need well balanced stats to defeat her.");
                    break;
                case 3:
                    Console.WriteLine($"You will face a mob of students.\n" +
                        $"Their attacks are highly variable, so concentrate on having a good weapon.");
                    break;
                case 4:
                    Console.WriteLine($"Adolf Hitler may appear weak, but has extremely strong defenses.\n" +
                        $"Concentrate on hitting him hard.");
                    break;
                case 5:
                    Console.WriteLine($"Your final challenge is to kill the White Whale.\n" +
                        $"You will need the best weapon and armour you can get.\n" +
                        $"Good luck!");
                    break;
                default:
                    Console.WriteLine($"If you see this, it is a bug. Please report it to the developer. Code: 1");
                    break;
            }
            
        }
    }
}
