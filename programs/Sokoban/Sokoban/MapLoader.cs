using System;
using System.Collections.Generic;
using static System.Console;

namespace Sokoban
{
    public class MapLoader
    {
        public List<List<string>> levels = new List<List<string>>();

        public void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(@"levels.txt");

            int level = 1;
            List<string> currentLevel = new List<string>();
            foreach (string line in lines)
            {
                if (line.Length > 0 && line[0] == ';')
                {
                    levels.Add(currentLevel);
                    currentLevel = new List<string>();
                    level++;
                    continue;
                }
                if (line.Trim() == "") continue;

                currentLevel.Add(line);
            }
        }

        public void Run()
        {
            bool runSelectScreen = true;
            while (runSelectScreen)
            {
                Write("Select level: ");
                int levelNum;
                if (int.TryParse(ReadLine(), out levelNum))
                {
                    if (levelNum >= 1 && levelNum <= levels.Count)
                    {
                        runSelectScreen = false;
                        Game game = new Game(levels[levelNum - 1]);
                        game.Run();
                    }
                    else
                    {
                        WriteLine("There is no such level... Try again");
                    }
                }
            }
        }
    }
}