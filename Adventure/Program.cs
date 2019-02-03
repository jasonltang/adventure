// Todo list
// Make the web service call to high scores stop after two minutes if not retrieved by then (async method).
// Add unit tests
// Make coins useful
// Think of a way to train stats
// Make attacks random

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = Player.GetInstance();
            while(true)
            {
                InputReader.GetAction(player);
            }
        }
    }
}
