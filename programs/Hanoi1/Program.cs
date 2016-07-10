using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
        int[] a = {5, 4, 0, 0, 0};
        int[] b = {3, 0, 0, 0, 0};
        int[] c = {2, 1, 0, 0, 0};
        DrawHanoi(n, a, b, c);
    }

    public static void DrawHanoi(int n, int[] a, int[] b, int[] c)
    {
        for (int i = n-1; i >= 0; i--)
        {
            DrawDisk(n, a[i]);
            Console.Write("\t");
            DrawDisk(n, b[i]);
            Console.Write("\t");
            DrawDisk(n, c[i]);
            Console.WriteLine();
        }
    }
    
    public static void DrawDisk(int n, int diskSize)
    {
        for (int i = 0; i <= 2*n; i++)
        {
            if (i < n - diskSize || i > n + diskSize)
            {
                Console.Write(' ');
            }
            else if (i != n)
            {
                Console.Write('*');
            }
            else
            {
                Console.Write('|');
            }
        }
    }
}
