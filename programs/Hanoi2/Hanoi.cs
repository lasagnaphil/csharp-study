using System;

public class Hanoi
{
    private HanoiTower[] towers;
    public int NumOfDisks { get; private set; }
    public int Turns { get; private set; }
    
    public Hanoi()
    {
        Turns = 0;

        Console.WriteLine("Enter number of disks : ");
        string input = Console.ReadLine();
        NumOfDisks = Convert.ToInt32(input);
        
        towers = new HanoiTower[3];
        for (int i = 0; i < 3; i++)
        {
            towers[i] = new HanoiTower(NumOfDisks);
        }
        towers[0].InsertAllDisks();
    }
    
    public void Run()
    {
        Turns = 0;
        ExecuteTurn(NumOfDisks, towers[0], towers[1], towers[2]);
        Console.WriteLine("Minimum number of moves : " + Turns);
    }
    private void ExecuteTurn(int n, HanoiTower source, HanoiTower via, HanoiTower dest)
    {
        if (n > 0)
        {
            ExecuteTurn(n - 1, source, dest, via);
            
            dest.InsertDisk(source.RemoveDisk());
            Turns++;
            Draw();

            ExecuteTurn(n - 1, via, source, dest);
        }
    }
    public void Draw()
    {
        Console.WriteLine();
        int n = NumOfDisks;
        for (int i = n-1; i >= 0; i--)
        {
            DrawDisk(n, towers[0].Disks[i]);
            Console.Write("\t");
            DrawDisk(n, towers[1].Disks[i]);
            Console.Write("\t");
            DrawDisk(n, towers[2].Disks[i]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    
    private void DrawDisk(int n, int diskSize)
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
