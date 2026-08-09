using UnityEngine;

public class GuestRegisterTest : MonoBehaviour
{
    
    void Start()
    {
        // 1. Register rooms into the ledger
        Room r1 = new Room(20, 1);
        Room r2 = new Room(30, 1);
        Room r3 = new Room(50, 2);

        // 2. Spawn in guest
        Guest g = new Guest();

        // 3. Guest requests a room with 1 bed and (min)30 size
        g.Request(0, 3);
    }


    void Update()
    {
        
    }
}
