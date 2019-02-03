using System;
using System.Text;
using System.IO;

namespace Adventure.Actions
{
    class LoadAction : IAction
    {
        public string GetText()
        {
            return "Load saved file";
        }

        public void Execute()
        {
            var player = Player.GetInstance();
            string line;
            if (!File.Exists("AdventureSaveFile.txt"))
            {
                Console.WriteLine("Can't find file AdventureSaveFile.txt!");
                return;
            }
            using (StreamReader sr = new StreamReader("AdventureSaveFile.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    if (!SaveAction.PLAINSAVE)
                    {
                        try
                        {
                            line = Encoding.UTF8.GetString(Convert.FromBase64String(line));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Couldn't decrypt save file!");
                            return;
                        }
                    }
                    try
                    {
                        var list = line.Split(',');
                        var fieldName = list[0];
                        var field = typeof(Player).GetField(fieldName);
                        var fieldValue = list[1];
                        if (field.FieldType == typeof(string))
                        {
                            field.SetValue(player, fieldValue);
                        }
                        else if (field.FieldType == typeof(int))
                        {
                            field.SetValue(player, int.Parse(fieldValue));
                        }
                        else if (field.FieldType == typeof(Guid))
                        {
                            field.SetValue(player, Guid.Parse(fieldValue));
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Couldn't read save file.");
                        return;
                    }
                }
            }
            Console.WriteLine("Progress loaded successfully!");
        }
    }
}
