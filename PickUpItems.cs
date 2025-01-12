using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    public ParticleSystem particlesBill;
    public ParticleSystem particlesStar;

    public ParticleSystem particlesBottle;
    public ParticleSystem particlesStarRed;

    public GameObject textMoney;
    public GameObject textMoneyRed;
    private GameObject temp;
    public Transform canvas;

    public AudioSource AS;
    public AudioClip coin, bottle;

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Money"))
        {
            PlayerInfo.moneyPlayer += 17;
            TextMoneyTake.moneyCombo += 2;

            if(temp == null)
            {
                temp = Instantiate(textMoney, new Vector3(50, -70, -1200), Quaternion.identity, canvas);
            }

            temp.transform.SetParent(canvas);
            temp.transform.localPosition = new Vector3(50, -70, -1200);

            AS.PlayOneShot(coin);
            particlesBill.Play();
            particlesStar.Play();
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Bottle"))
        {
            if(TextMoneyTake.moneyCombo > 0)
                TextMoneyTake.moneyCombo = 0;

            PlayerInfo.moneyPlayer -= 5;
            TextMoneyTake.moneyCombo -= 2;
            if (temp == null)
            {
                temp = Instantiate(textMoneyRed, new Vector3(-50, -70, -1200), Quaternion.identity, canvas);
            }

            temp.transform.SetParent(canvas);
            temp.transform.localPosition = new Vector3(-50, -70, -1200);

            AS.PlayOneShot(bottle);
            particlesBottle.Play();
            particlesStarRed.Play();
            Destroy(other.gameObject);
        }
    }
}
