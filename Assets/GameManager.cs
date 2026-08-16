using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;

    public void AddScore()
    {
        score++;
        Debug.Log("Score: " +  score);
    }
}
