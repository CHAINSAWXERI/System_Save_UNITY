using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class TextController : MonoBehaviour
{
    private int score = -1;
    [SerializeField] private TextView view;

    private void Start()
    {
        ChangeText();
    }

    public void ChangeText()
    {
        score++;
        view.UpdateText(score.ToString());
    }
}
