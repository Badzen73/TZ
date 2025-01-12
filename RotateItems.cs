using UnityEngine;

public class RotatePickups : MonoBehaviour
{
    private float rotateSpeed = 0.5f;

    private void FixedUpdate()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}
