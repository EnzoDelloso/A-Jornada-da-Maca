using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI finalText;

    void Update()
    {
        GameController.UpdateTimer(Time.deltaTime);

        if (timerText != null)
        {
            float t = GameController.TimeRemaining;
            int minutos = Mathf.FloorToInt(t / 60f);
            int segundos = Mathf.FloorToInt(t % 60f);
            timerText.text = $"{minutos:00}:{segundos:00}";
        }

        if (scoreText != null)
            scoreText.text = "Pontos: " + GameController.Score;

        if (livesText != null)
            livesText.text = "Vidas: " + GameController.Lives;

        if (GameController.gameOver)
        {
            if (endGamePanel != null)
                endGamePanel.SetActive(true);

            Time.timeScale = 0f;

            if (finalText != null)
                finalText.text = "Pontuacao final: " + GameController.Score;
        }
    }
}