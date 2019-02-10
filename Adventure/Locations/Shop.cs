using System.Collections.Generic;
using Adventure.Actions;
using Adventure.Actions.Shop;

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

        public override string LocationText {get { return
                    "You walk into the shop. A tough-looking guy comes out. He asks," +
                    "\"What would you like to buy?\""; } }

        public override string GetText()
        {
            return "Weapons and armour shop";
        }

        public override List<IAction> AllowedActions
        {
            get
            {
                return new List<IAction>()
                {
                    new ChangeLocationAction(Home.GetInstance()),
                    new BuyWeaponAction(),
                    new BuyArmourAction(),
                    new ViewPricesAction(),
                };
            }
        }
    }
}
