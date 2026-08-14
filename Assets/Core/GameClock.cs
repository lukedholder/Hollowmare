using UnityEngine;

public class GameClock : MonoBehaviour
{
    public static GameClock Instance { get; set; }

    public int firstTime = 360; // 6am
    public int lastTime = 1680; // 4am

    public int day = 0;
    public int timeOfDay = 0;    // in minutes

    public static event Action<int> DayEnding;  // day that just finished
    public static event Action<int> DayStarted; // the new day



    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject);
        }
        Instance = this;
    }

    public static void AdvanceDay() {
        DayEnding?Invoke(day);      // resolve the night: checkouts, growth, payments
        day++;
        timeOfDay = firstTime;
        DayStarted?.Invoke<day>;    // spawn arrivals, reset chores
    }
}
