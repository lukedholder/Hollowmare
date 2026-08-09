using UnityEngine;
using System.Collections.Generic;

public class Guest : MonoBehaviour
{
    public RoomRequirement reqs;
    // public family


    private void Awake() {
        reqs = new RoomRequirement(
            size: 30,
            luxuryRating: 4.0f,
            humidity: Humidity.Normal,
            cleanliness: 8.0f,
            // floor omitted -> no preference
            bedCount: 1,
            bedSizes: new List<BedSize> { BedSize.Twin },
            windowCount: 1,
            tableCount: 1,
            seatCount: 2);
    }

    public bool Request(int from, int to) {
        // Send reqs and dates to Hotel Ledger
        return true;
    }
}
