using UnityEngine;
using System.Collections.Generic;

public class Hotel : MonoBehaviour
{
    public static Hotel Instance { get; private set; }


    public float rating = 0.0f;
    public int guestCount = 0;
    public Dictionary<Room, List<int>> rooms = new Dictionary<Room, List<int>>();


    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject); 
            return;
        }

        Instance = this;
    }

    public List<int> GetAvailability(Room room) {    
        List<int> avaialableDays = new List<int>();

        if (rooms.TryGetValue(room, out List<int> bookedDays)) {
            for (int i = 0; i < 120; i++) { // caps at 1 year out
                if (!bookedDays.Contains(i)) {
                    avaialableDays.Add(i);
                }
            }
        }

        return avaialableDays;
    }
}
