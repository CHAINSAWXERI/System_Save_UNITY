using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    [SerializeField] public TMP_Text uiText;

    public void UpdateText(string newText)
    {
        uiText.text = newText;
    }
}
