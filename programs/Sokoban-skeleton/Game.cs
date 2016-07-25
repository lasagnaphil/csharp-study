using System;
using System.Collections.Generic;
using System.Linq;

namespace Sokoban
{
    public class Game
    {
        public const int Width = 10;
        public const int Height = 10;

        public Tile[,] Grid { get; private set; } = new Tile[Width, Height];
        private Player player = new Player(5, 5);
        private List<Block> blocks = new List<Block>();
        public List<Slot> slots = new List<Slot>();

        public Game()
        {
            ...
        }

        public void Run()
        {
            ...
        }

        public Block FindBlock(int x, int y)
        {
            ...
        }

        public void Print()
        {
            ...
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
