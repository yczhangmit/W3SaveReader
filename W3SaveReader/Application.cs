using System;
using System.IO;
using W3SaveReader.Savegame;
using W3SaveReader.Savegame.Variables;

namespace W3SaveReader
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please specify a game save path.");
                Environment.Exit(0);
            }

            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Game save not found.");
                Environment.Exit(0);
            }
            
            var save = SavegameFile.Read(args[0]);
            foreach (var variable in save.Variables)
            {
                if (!variable.Name.Equals("CR4GwintManager")) continue;
                var bsVar = (BsVariable) variable;
                foreach (var entry in bsVar.Variables)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }
    }
}