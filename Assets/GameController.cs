using UnityEngine;

public static class GameController
{
    private static float timeRemaining;
    private static float startTime = 60f;
    private static int score;
    private static int collectableCount;
    private static int lives;

    public static bool gameOver { get; private set; }

    public static float TimeRemaining => timeRemaining;
    public static int Score => score;
    public static int Lives => lives;

    public static void Init()
    {
        timeRemaining = startTime;
        score = 0;
        collectableCount = 7;
        lives = 3;
        gameOver = false;
    }

    public static void Collect()
    {
        score += 100;
        collectableCount--;

        if (collectableCount <= 0)
        {
            gameOver = true;
        }
    }

    public static void TakeDamage()
    {
        if (gameOver) return;

        lives--;

        if (lives <= 0)
        {
            gameOver = true;
        }
    }

    public static void UpdateTimer(float deltaTime)
    {
        if (gameOver) return;

        timeRemaining -= deltaTime;

        if (timeRemaining <= 0f)
        {
            timeRemaining = 0f;
            gameOver = true;
        }
    }
}