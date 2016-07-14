using System;

public class HanoiTower
{
    // The maximum number of disks allowed in this tower
    // readonly means a constant value (meaning that you cannot change it after initialization)
    private readonly int maxDisks;

    // All the disks in this tower (stored in an array)
    public int[] Disks { get; private set; }

    // The current number of disks
    public int TowerCount
    {
        get {...}
    }

    // Check if the tower is empty or not
    public bool Empty
    {
        get {...}
    }

    // constructor
    public HanoiTower(int maxDisks) {...}

    // Insert all disks into this tower
    // for instance, if maxDisk = 5, Disks = {5, 4, 3, 2, 1}
    public void InsertAllDisks() {...}

    // Insert a disk (with size diskSize) into this tower
    public void InsertDisk(int diskSize) {...}

    // Remove a disk from this tower (and return the disk's size)
    public int RemoveDisk() {...}
}
