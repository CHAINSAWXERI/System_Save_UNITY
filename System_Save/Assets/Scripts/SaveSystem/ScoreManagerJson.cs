using System.IO;
using UnityEngine;

public class ScoreManagerJson : MonoBehaviour, IScoreManager
{
    private string filePath;

    private void Awake()
    {
        // Определяем путь к файлу для сохранения данных
        filePath = Path.Combine(Application.persistentDataPath, "scoreData.json");
    }

    public void SaveScore(int score)
    {
        ScoreData data = LoadScoreData();
        data.score = score;

        // Обновляем высокий счет
        if (score > data.highScore)
        {
            data.highScore = score;
        }

        // Сохраняем данные в JSON
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, json);
    }

    public int LoadScore()
    {
        ScoreData data = LoadScoreData();
        return data.score;
    }

    public void ResetScore()
    {
        ScoreData data = new ScoreData(0, 0);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(filePath, json);
    }

    public int GetHighScore()
    {
        ScoreData data = LoadScoreData();
        return data.highScore;
    }

    private ScoreData LoadScoreData()
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonUtility.FromJson<ScoreData>(json);
        }
        else
        {
            // Если файл не найден, возвращаем новый объект ScoreData
            return new ScoreData(0, 0);
        }
    }
}
