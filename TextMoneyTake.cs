using TMPro;
using UnityEngine;

public class TextMoneyTake : MonoBehaviour
{
    private float speed = 2;
    private Vector3 startPos;
    public static int moneyCombo;
    public bool red;
    public TextMeshProUGUI text;

    void Start()
    {
        if (!red)
            moneyCombo = 2;
        else
            moneyCombo = -2;

        startPos = transform.position;
    }

    void Update()
    {
        if(!red)
        {
            text.text = "+ " + moneyCombo;

            transform.localPosition += new Vector3(0, speed, 0);

            if (transform.localPosition.y >= 0)
                Destroy(gameObject);
        }

        else if(red)
        {
            text.text = "" + moneyCombo;

            transform.localPosition += new Vector3(0, -speed, 0);

            if (transform.localPosition.y <= -140)
                Destroy(gameObject);
        }
    }

    private int myVariable;
    public int MyVariable
    {
        get { return myVariable; }
        set
        {
            myVariable = value;
            OnMyVariableChanged();
        }
    }

    private void OnMyVariableChanged()
    {
        transform.position = startPos;
    }
}
