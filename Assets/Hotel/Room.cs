// using UnityEngine;
using System.Collections.Generic;


public class RoomRequirement {
    public int size = -1;
    public int bedCount = -1;

    public RoomRequirement(int _size, int _bedCount) {
        this.size = _size;
        this.bedCount = _bedCount;
    }
}


public class Room {
    public int size = -1;
    public int bedCount = -1;

    public Room(int _size, int _bedCount) { 
        size = _size;
        bedCount = _bedCount;
        Hotel.Instance.RegisterRoom(this);
    }


    public bool HasReq(RoomRequirement req) {
        if (req.size != -1      && req.size != size)          { return false; }
        if (req.bedCount != -1  && req.bedCount != bedCount)  { return false; }

        return true;
    }
}