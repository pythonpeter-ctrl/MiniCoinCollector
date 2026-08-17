using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject joystick;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text finalTimeText;


    private float elapsedTime;
    private int score = 0;
    private const int targetScore = 20;

    private void Awake()
    {
        Time.timeScale = 1f;

        timerText.gameObject.SetActive(true);
        scoreText.text = "SCORE: 0";
        gameOverPanel.SetActive(false);

    }

    private void Update()
    {
        elapsedTime += Time.deltaTime;

        timerText.text = "Time: "+ elapsedTime.ToString("F1")+"s";
    }

    public void AddScore()
    {
        score++;

        scoreText.text = "SCORE: " + score;

        if (score >= targetScore)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameOverPanel.SetActive(true);
        joystick.SetActive(false);
        timerText.gameObject.SetActive(false);
        finalTimeText.text = "Time: " + elapsedTime.ToString("F1") + "s";
        Time.timeScale = 0f;

        Debug.Log("Game Over! 30 coins collected.");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
        );
    }
}