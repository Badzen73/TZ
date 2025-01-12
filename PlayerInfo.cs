using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    public static float moneyPlayer;
    public static int level;

    public Image fillLine;

    private void Update()
    {
        fillLine.fillAmount = moneyPlayer * 0.01f; 
    }
}
