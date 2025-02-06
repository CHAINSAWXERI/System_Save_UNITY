using UnityEngine;

public class TextController : MonoBehaviour
{
    private int score;
    [SerializeField] private TextView view;
    [SerializeField] private ScoreManager scoreManager; // —сылка на ScoreManager

    private void Start()
    {
        LoadScore();
        ChangeText();
    }

    public void ChangeText()
    {
        score++;
        view.UpdateText(score.ToString());
        SaveScore();
    }

    private void SaveScore()
    {
        scoreManager.SaveScore(score);
    }

    private void LoadScore()
    {
        score = scoreManager.LoadScore();
    }
}