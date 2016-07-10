using System;

public class Hanoi
{
    private HanoiTower[] towers;
    public int NumOfDisks { get; private set; }
    public int Turns { get; private set; }
    
    public Hanoi() {...}
    
    public void Run() {...}
    private void ExecuteTurn(int n, HanoiTower source, HanoiTower via, HanoiTower dest) {...}
    public void Draw() {...}
    
    private void DrawDisk(int n, int diskSize) {...}
}
