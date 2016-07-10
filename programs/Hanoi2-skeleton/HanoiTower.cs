using System;

public class HanoiTower
{
    private readonly int maxDisks;
    public int[] Disks { get; private set; }
    public int TowerCount
    {
        get {...}
    }

    public bool Empty
    {
        get {...}
    }

    public HanoiTower(int maxDisks) {...}
    public void InsertAllDisks() {...}
    public void InsertDisk() {...}
    public void RemoveDisk() {...}
}