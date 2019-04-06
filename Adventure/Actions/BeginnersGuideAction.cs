using System;

namespace Adventure.Actions
{
    public class BeginnersGuideAction : IAction
    {
        public string GetText()
        {
            return "Beginner's guide";
        }

        public void Execute()
        {
            Console.WriteLine("Welcome to Adventure!\n");
            Console.WriteLine("This is a text-based role-playing game.");
            Console.WriteLine("Use the letter commands to navigate through the game.");
            Console.WriteLine("Battle enemies to earn gold and confidence.\n");
            Console.WriteLine("There are five areas to battle through, with progressively stronger enemies.");
            Console.WriteLine("To advance to the next area, you will have to defeat the Trial Boss.\n");
            Console.WriteLine("Make sure to upgrade your weapons and armour at Zelda's Weapons and Armour.\n");
            Console.WriteLine("You can also save the game to continue from where you left off next time.");
            Console.WriteLine("Don't forget to upload your high score!");
        }
    }
}
