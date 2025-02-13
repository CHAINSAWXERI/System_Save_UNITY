using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScoreManager
{
    void SaveScore(int score);
    int LoadScore();
    void ResetScore();
    int GetHighScore();
}
