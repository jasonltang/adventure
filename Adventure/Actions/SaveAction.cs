using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Adventure.Actions
{
    class SaveAction : IAction
    {
        public string GetText()
        {
            return "Save progress";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            using (StreamWriter sw = new StreamWriter("SaveFile.txt"))
            {
                sw.WriteLine(nameof(player.MaxHitpoints) + " " + player.MaxHitpoints);
                sw.WriteLine(nameof(player.Hitpoints) + " " + player.Hitpoints);
                sw.WriteLine(nameof(player.Attack) + " " + player.Attack);
                sw.WriteLine(nameof(player.Defense) + " " + player.Defense);
            }
        }
    }
}
