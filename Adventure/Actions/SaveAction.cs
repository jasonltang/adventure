using System;
using System.Text;
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
            if (File.Exists("AdventureSaveFile.txt"))
            {
                Console.WriteLine("There is already a save file. Do you want to overwrite? (Y/N)");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.WriteLine("Cancelled save.");
                    return;
                }
            }
            var player = Player.GetInstance();
            if (PLAINSAVE)
            {
                using (StreamWriter sw = new StreamWriter("AdventureSaveFile.txt"))
                {
                    sw.WriteLine(nameof(player.ID) + "," + player.ID);
                    sw.WriteLine(nameof(player.Name) + "," + player.Name);
                    sw.WriteLine(nameof(player.MaxHitpoints) + "," + player.MaxHitpoints);
                    sw.WriteLine(nameof(player.Hitpoints) + "," + player.Hitpoints);
                    sw.WriteLine(nameof(player.Attack) + "," + player.Attack);
                    sw.WriteLine(nameof(player.Defense) + "," + player.Defense);
                    sw.WriteLine(nameof(player.HitpointsExp) + "," + player.HitpointsExp);
                    sw.WriteLine(nameof(player.AttackExp) + "," + player.AttackExp);
                    sw.WriteLine(nameof(player.DefenseExp) + "," + player.DefenseExp);
                    sw.WriteLine(nameof(player.TrainingMode) + "," + player.TrainingMode);
                    sw.WriteLine(nameof(player.Gold) + "," + player.Gold);
                    sw.WriteLine(nameof(player.Confidence) + "," + player.Confidence);
                    sw.WriteLine(nameof(player.Deaths) + "," + player.Deaths);
                }
            }
            else
            {
                using (StreamWriter sw = new StreamWriter("AdventureSaveFile.txt"))
                {
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.ID) + "," + player.ID)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Name) + "," + player.Name)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.MaxHitpoints) + "," + player.MaxHitpoints)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Hitpoints) + "," + player.Hitpoints)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Attack) + "," + player.Attack)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Defense) + "," + player.Defense)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.HitpointsExp) + "," + player.HitpointsExp)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.AttackExp) + "," + player.AttackExp)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.DefenseExp) + "," + player.DefenseExp)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Gold) + "," + player.Gold)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Confidence) + "," + player.Confidence)));
                    sw.WriteLine(Convert.ToBase64String(Encoding.UTF8.GetBytes(nameof(player.Deaths) + "," + player.Deaths)));
                }
            }
            Console.WriteLine("Progress saved successfully!");
        }
    }
}
