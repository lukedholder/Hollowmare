using UnityEngine;
using System.Collections.Generic;


public enum Humidity {
    Dry, Normal, Wet
} 
public enum BedSize {
    Twin, Full, Queen, King
}

public struct RoomRequirement {
    public int? Size;
    public int? BedCount;

    public RoomRequirement(int? size = null, int? bedCount = null) {
        this.Size = size;
        this.BedCount = bedCount;
    }
}

public struct RoomStats
{
    public int? Size;
    public int? BedCount;

    public RoomStats(int? size = null, int? bedCount = null) {
        this.Size = size;
        this.BedCount = bedCount;
    }
}


public class Room : MonoBehaviour
{
    public RoomStats stats;


    public Room(int? size = null, int? bedCount = null) { // Regsiter room in ledger on creation
        stats = new RoomStats(size, bedCount);
        Hotel.Instance.RegisterRoom(this);
    }

    public bool HasReq(RoomRequirement req) {
        if (req.Size != null            && req.Size != stats.Size)                  { return false; }
        if (req.BedCount != null        && req.BedCount != stats.BedCount)          { return false; }

        return true;
    }
}