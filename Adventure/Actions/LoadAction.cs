using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

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
            using (StreamReader sr = new StreamReader("SaveFile.txt"))
            {
                while((line = sr.ReadLine()) != null)
                {
                    var list = line.Split(' ');
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
                }
            }
        }
    }
}
