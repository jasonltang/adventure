// Todo list
// Make coins useful (weapon shop, armour shop)
// Add some more difficult monsters
// Separate monsters by stage
// Add bosses for each level
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
