using System;

public class HanoiTower
{
    private readonly int maxDisks;
    public int[] Disks { get; private set; }
    public int DiskCount
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
        get { return DiskCount == 0; }
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
        if (DiskCount == maxDisks)
        {
            Console.WriteLine("Tower is full!");
            return;
        }
        Disks[DiskCount] = diskSize;
    }

    public int RemoveDisk()
    {
        if (DiskCount == 0)
        {
            Console.WriteLine("Tower is empty!");
            return 0;
        }
        int removedDisk = Disks[DiskCount - 1];
        Disks[DiskCount - 1] = 0;
        return removedDisk;
    }

}
