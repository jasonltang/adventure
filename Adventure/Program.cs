// Todo list
// Separate monsters by stage
// Give every enemy an attack
// Add bosses for each level
// Add some more difficult monsters
// Introduce 'standard deviation' of attacks
// Set a ceiling for leveling up, i.e. don't throw error when beating lv 10
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
