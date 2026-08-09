using UnityEngine;
using System.Collections.Generic;

public class Guest : MonoBehaviour
{
    public RoomRequirement reqs;
    // public family


    public Guest() {
        reqs = new RoomRequirement(
            size: 30,
            bedCount: 1);
    }

    public bool Request(int from, int to) {
        // Send reqs and dates to Hotel Ledger
        return true;
    }

    // Manage guest spawning
}
