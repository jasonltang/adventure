using System.Collections.Generic;
using System.Linq;
using System.Text;
using Adventure.Actions;

namespace Adventure.Locations
{
    class Shop : Location
    {
        private static Shop _instance;
        public static Shop GetInstance()
        {
            if (_instance == null) _instance = new Shop();
            return _instance;
        }
        private Shop()
        {

        }

        public override string LocationText {
            get
            {
                var weaponList = Helpers.GetWeapon.ToDictionary(entry => entry.Key, entry => entry.Value);
                weaponList.Remove(0);
                var armourList = Helpers.GetArmour.ToDictionary(entry => entry.Key, entry => entry.Value);
                armourList.Remove(0);
                var sb = new StringBuilder();
                sb.AppendLine("You walk into the shop. A tough-looking guy comes out.");
                sb.AppendLine("He asks, \"What would you like to buy?\"");
                sb.AppendLine();
                sb.AppendLine("Weapons:");
                foreach (var w in weaponList)
                {
                    sb.AppendLine($"{w.Key}.".PadRight(4) + $"{w.Value.Name}".PadRight(19) + $"{w.Value.Price}");
                }
                sb.AppendLine();
                sb.AppendLine("Armour:");
                foreach (var a in armourList)
                {
                    sb.AppendLine($"{a.Key}.".PadRight(4) + $"{a.Value.Name}".PadRight(19) + $"{a.Value.Price}");
                }
                sb.AppendLine();
                sb.AppendLine("\"w 2\" to buy weapon number 2, \"a 5\" to buy armour 5, etc.");
                sb.AppendLine();
                sb.AppendLine($"Current weapon: {Helpers.GetWeapon[Player.GetInstance().Weapon].Name}");
                sb.AppendLine($"Current armour: {Helpers.GetArmour[Player.GetInstance().Armour].Name}");
                sb.AppendLine($"Your gold: {Player.GetInstance().Gold}");
                return sb.ToString();
            }
        }

        public override string GetText()
        {
            return "Buy weapons and armour";
        }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(Home.GetInstance()),
                };
            }
        }
    }
}
