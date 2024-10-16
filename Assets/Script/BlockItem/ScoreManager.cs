using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    private int score = 0;

    // ??m b?o ScoreManager l� singleton
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Gi? ScoreManager khi chuy?n scene
        }
        else
        {
            Destroy(gameObject); // H?y n?u c� instance kh�c t?n t?i
        }
    }

    // H�m ?? th�m ?i?m
    public void AddPoints(int points)
    {
        score += points;
        Debug.Log("Current Score: " + score);
    }

    // H�m ?? l?y ?i?m hi?n t?i
    public int GetScore()
    {
        return score;
    }
}
