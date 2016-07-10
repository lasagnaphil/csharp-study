using System;

public class HanoiTower
{
    private readonly int maxDisks;
    public int[] Disks { get; private set; }
    public int TowerCount
    {
        get 
        {
            for (int i = 0; i < maxDisks; i++)
            {
                if (Disks[i] == 0) return i;
            }
            return maxDisks;
        }
    }
    public bool Empty
    {
        get { return TowerCount == 0; }
    }

    public HanoiTower(int maxDisks)
    {
        this.maxDisks = maxDisks;
        Disks = new int[maxDisks];
    }

    public void InsertAllDisks()
    {
        for (int i = 0; i < maxDisks; i++)
        {
            Disks[i] = maxDisks - i;
        }
    }

    public void InsertDisk(int diskSize)
    {
        if (TowerCount == maxDisks)
        {
            Console.WriteLine("Tower is full!");
            return;
        }
        Disks[TowerCount] = diskSize;
    }

    public int RemoveDisk()
    {
        if (TowerCount == 0)
        {
            Console.WriteLine("Tower is empty!");
            return 0;
        }
        int removedDisk = Disks[TowerCount - 1];
        Disks[TowerCount - 1] = 0;
        return removedDisk;
    }

}
