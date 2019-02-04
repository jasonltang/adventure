// Todo list
// Introduce 'confidence' and make deaths lose confidence
// Make coins useful (atk and def same bonus)
// Make attacks random
// Think of a way to train stats
// Add unit tests
// Integrate with Jenkins

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
