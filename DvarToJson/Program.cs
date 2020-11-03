using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DvarToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "C:\\Users\\Light\\Desktop\\dvar.txt";
            List<Command> commands = new List<Command>();
            int size = File.ReadAllLines(file).Count();
            int i = 0;
            foreach (string line in File.ReadAllLines(file))
            {
                string[] dvarSplited = line.Split(new string[] { "//" }, StringSplitOptions.None);
                commands.Add(new Command { Content = dvarSplited[0], Description = (dvarSplited.Count() > 1) ? dvarSplited[1] : ""});
                i++;
                Console.WriteLine($"Progress : {i} / {size}");
            }
            Console.WriteLine("Write in file : C:\\Users\\Light\\Desktop\\allDvar.json");
            using (JsonWriter writer = new JsonTextWriter(new StreamWriter($"C:\\Users\\Light\\Desktop\\allDvar.json")))
            {
                new JsonSerializer().Serialize(writer, commands);
            }
            Console.WriteLine("Done :)");
            Console.ReadLine();
        }
    }


    class Command
    {
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
 