using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 mousePos, mousePos_1, posDiff;

    static public float clampedX;
    private Vector3 posEnd;

    private float minX = -1, maxX = 1; // ������������ �� ��������� 

    private void Start()
    {
        // �������� RigidBody 
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // ������ �������� ������ ������
        rb.velocity = Vector3.forward * speed;
    }

    private void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //    mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition); // �� �����

        // ���������, ������ �� ����� ������ ����
        if (Input.GetMouseButton(0))
        {
            // �������� ������� ������� ����
            mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition);

            //posDiff = mousePos_1 - mousePos; // �� �����

            // ����������� �� �����������
            clampedX = Mathf.Clamp(-(mousePos.x / 7000) - 0.7f, minX, maxX);

            // ������� ����� �������, �� ����� Y � Z
            posEnd = new Vector3(clampedX, rb.position.y, rb.position.z);

            // ���������� ������ � ����� �������
            rb.MovePosition(posEnd);
        }

        //if(Input.touchCount == 1)
        //{
        //    // �������� ������� ����
        //    mousePos = Camera.main.WorldToScreenPoint(Input.touches[0].deltaPosition);

        //    //posDiff = mousePos_1 - mousePos; // �� �����

        //    // ����������� �� �����������
        //    clampedX = Mathf.Clamp(-(mousePos.x / 7000) - 0.7f, minX, maxX);

        //    // ������� ����� �������, �� ����� Y � Z
        //    posEnd = new Vector3(clampedX, rb.position.y, rb.position.z);

        //    // ���������� ������ � ����� �������
        //    rb.MovePosition(posEnd);
        //}

        else if (!Input.GetMouseButton(0))
            clampedX = 0;
    }
}
