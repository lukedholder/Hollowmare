using UnityEngine;
using System.Collections.Generic;


public enum Humidity {
    Dry, Normal, Wet
} 
public enum BedSize {
    Twin, Full, Queen, King
}

[System.Serializable]
public struct RoomRequirement { // a field left null means no preference
    public int? Size;
    public float? LuxuryRating;
    public Humidity? Humidity;
    public float? Cleanliness;
    public int? Floor;
    public int? BedCount;
    public List<BedSize> BedSizes;
    public int? WindowCount;
    public int? TableCount;
    public int? SeatCount;

    public RoomRequirement(int? size = null, float? luxuryRating = null,
                            Humidity? humidity = null, float? cleanliness = null,
                            int? floor = null, int? bedCount = null,
                            List<BedSize> bedSizes = null, int? windowCount = null,
                            int? tableCount = null, int? seatCount = null) {
        this.Size = size;
        this.LuxuryRating = luxuryRating;
        this.Humidity = humidity;
        this.Cleanliness = cleanliness;
        this.Floor = floor;
        this.BedCount = bedCount;
        this.BedSizes = bedSizes;
        this.WindowCount = windowCount;
        this.TableCount = tableCount;
        this.SeatCount = seatCount;
    }
}

public struct RoomStats
{
    public int? Size;        // by tile count
    public float? LuxuryRating;
    public Humidity? Humidity;
    public float? Cleanliness;
    public int? Floor;
    public int? BedCount;
    public List<BedSize> BedSizes;
    public int? WindowCount; // by tile count so bigger windows are worth more
    public int? TableCount;
    public int? SeatCount;
}


public class Room : MonoBehaviour
{
    public RoomStats stats;

    public bool HasReq(RoomRequirement req) {
        if (req.Size != null            && req.Size != stats.Size)                  { return false; }
        if (req.LuxuryRating != null    && req.LuxuryRating != stats.LuxuryRating)  { return false; }
        if (req.Humidity != null        && req.Humidity != stats.Humidity)          { return false; }
        if (req.Cleanliness != null     && req.Cleanliness != stats.Cleanliness)    { return false; }
        if (req.BedCount != null        && req.BedCount != stats.BedCount)          { return false; }
        if (req.BedSizes != null         && req.BedSizes != stats.BedSizes)            { return false; }
        if (req.WindowCount != null     && req.WindowCount != stats.WindowCount)    { return false; }
        if (req.TableCount != null      && req.TableCount != stats.TableCount)      { return false; }
        if (req.SeatCount != null       && req.SeatCount != stats.SeatCount)        { return false; }

        return true;
    }
}