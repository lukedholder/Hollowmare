using UnityEngine;

public class GuestRegisterTest : MonoBehaviour
{
    
    void Start()
    {
        Guest g = new Guest();
        g.Request(0, 3);
    }


    void Update()
    {
        
    }
}
