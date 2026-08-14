using UnityEngine;
using System.Collections.Generic;

public class Guest
{
    public RoomRequirement reqs;
    // public familyWithThem


    public Guest(int _size = -1, int _bedCount = -1) {
        reqs = new RoomRequirement(
            _size: _size,
            _bedCount: _bedCount);
    }

    public bool Request(int from, int to) {
        // Send reqs and dates to Hotel Ledger
        return true;
    }

    // Manage guest spawning
}
