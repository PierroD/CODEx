using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace DvarToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            FromFileWithComment("C:\\Users\\Light\\Desktop\\dvar.txt", "C:\\Users\\Light\\Desktop\\allDvar.json");
           // FromFileWith2Lines("C:\\Users\\Light\\Desktop\\dvar.txt", "C:\\Users\\Light\\Desktop\\allDvar.json");
            Console.WriteLine("Done :)");
            Console.ReadLine();
        }

        static void FromFileWithComment(string inputPath, string outputPath)
        {
            List<Command> commands = new List<Command>();
            int size = File.ReadAllLines(inputPath).Count();
            int i = 0;
            foreach (string line in File.ReadAllLines(inputPath))
            {
                string[] dvarSplited = line.Split(new string[] { "//" }, StringSplitOptions.None);
                commands.Add(new Command { Content = dvarSplited[0], Description = (dvarSplited.Count() > 1) ? dvarSplited[1] : "" });
                i++;
                Console.WriteLine($"Progress : {i} / {size}");
            }
            Console.WriteLine($"Write in file : {outputPath}");
            using (JsonWriter writer = new JsonTextWriter(new StreamWriter(outputPath)))
            {
                new JsonSerializer().Serialize(writer, commands);
            }
        }

        static void FromFileWith2Lines(string inputPath, string outputPath)
        {
            List<Command> commands = new List<Command>();
            string[] dvar = File.ReadAllLines(inputPath);
            int size = File.ReadAllLines(inputPath).Count();
            for (int i = 0; i < size-1; i +=2)
            {
                commands.Add(new Command { Content = dvar[i], Description = (dvar[i + 1].Equals("missing description") ? "" : dvar[i + 1]) });
                Console.WriteLine($"Progress : {i+2} / {size}");
            }
            Console.WriteLine($"Write in file : {outputPath}");
            using (JsonWriter writer = new JsonTextWriter(new StreamWriter(outputPath)))
            {
                new JsonSerializer().Serialize(writer, commands);
            }
        }
    }


    class Command
    {
        public string Content { get; set; }
        public string Description { get; set; }
    }
}
