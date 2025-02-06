using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private const string ScoreKey = "Score";

    public void SaveScore(int score)
    {
        PlayerPrefs.SetInt(ScoreKey, score);
        PlayerPrefs.Save();
    }

    public int LoadScore()
    {
        return PlayerPrefs.GetInt(ScoreKey, 0);
    }
}
