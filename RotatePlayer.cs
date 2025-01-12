using UnityEngine;

public class RotatePlayer : MonoBehaviour
{
    private float eulerRotate = 45;
    private Quaternion rotation;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (MovePlayer.clampedX > 0)
        {
            rotation = Quaternion.Euler(0, eulerRotate * MovePlayer.clampedX, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10f);
        }

        else if (MovePlayer.clampedX < 0)
        {
            rotation = Quaternion.Euler(0, eulerRotate * MovePlayer.clampedX, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10f);
        }

        else
        {
            rotation = Quaternion.Euler(0, 0, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 10f);
        }
    }
}
