[System.Serializable]
public class ScoreData
{
    public int score;
    public int highScore;

    public ScoreData(int score, int highScore)
    {
        this.score = score;
        this.highScore = highScore;
    }
}
