using UnityEngine;

public class ScoreManager : MonoBehaviour, IScoreManager
{
    private const string ScoreKey = "Score";
    private const string HighScoreKey = "HighScore";

    public void SaveScore(int score)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
        UpdateHighScore(score);
    }

    public int LoadScore()
    {
        return PlayerPrefs.GetInt(ScoreKey, 0);
    }

    public void ResetScore()
    {
        PlayerPrefs.DeleteKey(ScoreKey);
        PlayerPrefs.Save();
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt(HighScoreKey, 0);
    }

    private void UpdateHighScore(int score)
    {
        int highScore = GetHighScore();
        if (score > highScore)
        {
            PlayerPrefs.SetInt(HighScoreKey, score);
            PlayerPrefs.Save();
        }
    }

    // Убедитесь, что этот метод не вызывает увеличение счёта
}