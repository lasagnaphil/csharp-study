using System;
using System.Collections.Generic;
using System.Linq;

namespace Sokoban
{
    public class Game
    {
        public readonly int Width;
        public readonly int Height;

        public Tile[,] Grid { get; private set; }
        private Player player;
        private List<Block> blocks = new List<Block>();
        public List<Slot> slots = new List<Slot>();

        public Game()
        {
            player = new Player(5, 5);
            blocks = new List<Block>()
            {
                new Block(2, 2),
                new Block(2, 3),
                new Block(7, 7),
                new Block(7, 6)
            };
            Width = 10;
            Height = 10;
            Grid = new Tile[Width, Height];

            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    if (x == 0 || x == Grid.GetLength(0) - 1 ||
                        y == 0 || y == Grid.GetLength(1) - 1)
                        Grid[x, y] = new Wall();
                    else Grid[x, y] = new Floor();
                }
            }
            Grid[4, 4] = new Slot();
            Grid[4, 5] = new Slot();
            Grid[5, 4] = new Slot();
            Grid[5, 5] = new Slot();

            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    Slot slot = Grid[x, y] as Slot;
                    if (slot != null) slots.Add(slot);
                }
            }
        }

        public Game(List<string> data)
        {
            Console.Clear();

            Width = data.Max(str => str.Length);
            Height = data.Count;
            Grid = new Tile[Width, Height];

            for (int y = 0; y < data.Count; y++)
            {
                string line = data[y];
                for (int x = 0; x < line.Length; x++)
                {
                    switch (line[x])
                    {
                        case '#':
                            Grid[x, y] = new Wall();
                            break;
                        case '.':
                            Slot slot = new Slot();
                            Grid[x, y] = slot;
                            slots.Add(slot);
                            break;
                        case ' ':
                            Grid[x, y] = new Floor();
                            break;
                        case '@':
                            player = new Player(x, y);
                            break;
                        case '$':
                            blocks.Add(new Block(x, y));
                            break;
                    }
                }
            }
            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    if (Grid[x, y] == null) Grid[x, y] = new Floor();
                }
            }
        }

        public void Run()
        {

            bool isRunning = true;
            while (isRunning)
            {
                Print();
                var keyInfo = Console.ReadKey(true);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        player.TryMove(this, -1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        player.TryMove(this, 1, 0);
                        break;
                    case ConsoleKey.UpArrow:
                        player.TryMove(this, 0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        player.TryMove(this, 0, 1);
                        break;
                    case ConsoleKey.Q:
                        isRunning = false;
                        break;
                }

                if (slots.Count(slot => !slot.IsFilled) == 0)
                {
                    Print();
                    PrintLog("Level Complete!");
                    isRunning = false;
                    Console.ReadKey();
                }
            }
        }

        public Block FindBlock(int x, int y)
        {
            foreach (Block block in blocks)
            {
                if (block.X == x && block.Y == y) return block;
            }
            return null;
        }
        public void Print()
        {
            Console.SetCursorPosition(0, 0);

            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    Print(Grid[x, y].Symbol, x, y);
                }
            }

            foreach (Block block in blocks)
            {
                Print(block.Symbol, block.X, block.Y);
            }

            for (int x = 0; x < Grid.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.GetLength(1); y++)
                {
                    if (Grid[x, y] is Slot)
                    {
                        Print(Grid[x, y].Symbol, x, y);
                    }
                }
            }

            Print(player.Symbol, player.X, player.Y);
        }

        public static void Print(char c, int left, int top)
        {
            Console.SetCursorPosition(left*2, top);
            Console.WriteLine(c);
        }

        public static void PrintLog(string message)
        {
            int cursorLeft = Console.CursorLeft;
            int cursorTop = Console.CursorTop;
            Console.SetCursorPosition(0, 12);
            Console.WriteLine(message);
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
    }
}