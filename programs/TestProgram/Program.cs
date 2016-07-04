using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintTower(0, 5, 4, 4);
        }

        public static void FizzBuzz1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }
        }

        public static void FizzBuzz2()
        {
            List<string> outputs = Enumerable.Range(1, 100)
                .Select(x =>
                {
                    if (x % 15 == 0) return "FizzBuzz";
                    else if (x % 3 == 0) return "Fizz";
                    else if (x % 5 == 0) return "Buzz";
                    else return x.ToString();
                }).ToList();
            outputs.ForEach(Console.WriteLine);
        }

        public static void PrintTower(int x, int y, int n, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                WriteAtPosition('|', x + size, y + i);
                for (int j = 1; j <= i; j++)
                {
                    WriteAtPosition('-', x + size + j, y + i);
                    WriteAtPosition('-', x + size - j, y + i);
                }
            }
        }

        public static void WriteAtPosition(char c, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
        }
    }
}
