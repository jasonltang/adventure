using System;
using System.Linq;

namespace Adventure.Actions.Shop
{
    public class ViewPricesAction : IAction
    {
        public string GetText()
        {
            return "View prices";
        }

        public void Execute()
        {
            Console.WriteLine("Weapons:");
            var weaponList = Helpers.GetWeapon.ToDictionary(entry => entry.Key, entry => entry.Value);
            weaponList.Remove(0);
            foreach(var w in weaponList)
            {
                Console.WriteLine($"{w.Key}. {w.Value.Name}  {w.Value.Price}");
            }
            Console.WriteLine();

            Console.WriteLine("Armour:");
            var armourList = Helpers.GetArmour.ToDictionary(entry => entry.Key, entry => entry.Value);
            armourList.Remove(0);
            foreach (var a in armourList)
            {
                Console.WriteLine($"{a.Key}. {a.Value.Name}  {a.Value.Price}");
            }
            Console.WriteLine();
            Console.WriteLine($"Your gold: {Player.GetInstance().Gold}");
        }
    }
}
