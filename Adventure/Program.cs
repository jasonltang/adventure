// Todo list
// Separate monsters by stage
// Add bosses for each level
// Add some more difficult monsters
// Introduce 'standard deviation' of attacks
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
