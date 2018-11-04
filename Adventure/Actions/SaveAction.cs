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
        public const bool PLAINSAVE = true;

        public string GetText()
        {
            return "Save progress";
        }

        public void Execute()
        {
            var player = Player.GetInstance();

            if (PLAINSAVE)
            {
                using (StreamWriter sw = new StreamWriter("SaveFile.txt"))
                {
                    sw.WriteLine(nameof(player.MaxHitpoints) + " " + player.MaxHitpoints);
                    sw.WriteLine(nameof(player.Hitpoints) + " " + player.Hitpoints);
                    sw.WriteLine(nameof(player.Attack) + " " + player.Attack);
                    sw.WriteLine(nameof(player.Defense) + " " + player.Defense);
                    sw.WriteLine(nameof(player.Gold) + " " + player.Gold);
                    sw.WriteLine(nameof(player.Deaths) + " " + player.Deaths);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("AdventureSaveFile.txt"))
                {
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.MaxHitpoints) + " " + player.MaxHitpoints)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Hitpoints) + " " + player.Hitpoints)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Attack) + " " + player.Attack)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Defense) + " " + player.Defense)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Gold) + " " + player.Gold)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Deaths) + " " + player.Deaths)));
                }
            }
        }
    }
}
