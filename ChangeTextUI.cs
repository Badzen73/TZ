using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Outline outlineBG;
    public Image imageFill;

    void Update()
    {
        if (PlayerInfo.level == 1)
        {
            text.text = "Состоятельный";
            text.color = Color.yellow;
            outlineBG.effectColor = Color.yellow;
            imageFill.color = Color.yellow;
        }
    }
}
