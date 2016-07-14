using System;

public class Hanoi
{
    // The three tower objects
    private HanoiTower[] towers;

    // Maximum number of disks in this Hanoi program
    public int NumOfDisks { get; private set; }

    // The current number of turns in the hanoi program
    public int Turns { get; private set; }

    // Constructor
    public Hanoi() {...}

    // Method to start the hanoi program
    public void Run() {...}

    // Execute a turn (recursive method) and draw the towers to the screen
    private void ExecuteTurn(int n, HanoiTower source, HanoiTower via, HanoiTower dest) {...}

    // Draw the hanoi tower and disks
    public void Draw() {...}

    // Draw one disk (used in Draw() method)
    private void DrawDisk(int n, int diskSize) {...}
}
