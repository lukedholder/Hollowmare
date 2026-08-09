using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }


    public int day = 0;
    public float time = 0.0f;


    private void Awake() {
        if (Instance != null && Instance != this) {
            Destroy(gameObject); 
            return;
        }

        Instance = this;
    }
}
