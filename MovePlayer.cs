using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 mousePos, mousePos_1, posDiff;

    static public float clampedX;
    private Vector3 posEnd;

    private float minX = -1, maxX = 1; // Ограничители по движениям 

    private void Start()
    {
        // Получаем RigidBody 
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Делаем движение игрока вперед
        rb.velocity = Vector3.forward * speed;
    }

    private void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //    mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition); // Не успел

        // Проверяем, зажата ли левая кнопка мыши
        if (Input.GetMouseButton(0))
        {
            // Получаем позицию курсора мыши
            mousePos = Camera.main.WorldToScreenPoint(Input.mousePosition);

            //posDiff = mousePos_1 - mousePos; // Не успел

            // Ограничение по перемещению
            clampedX = Mathf.Clamp(-(mousePos.x / 7000) - 0.7f, minX, maxX);

            // Создаем новую позицию, не меняя Y и Z
            posEnd = new Vector3(clampedX, rb.position.y, rb.position.z);

            // Перемещаем объект к новой позиции
            rb.MovePosition(posEnd);
        }

        //if(Input.touchCount == 1)
        //{
        //    // Получаем позицию тапа
        //    mousePos = Camera.main.WorldToScreenPoint(Input.touches[0].deltaPosition);

        //    //posDiff = mousePos_1 - mousePos; // Не успел

        //    // Ограничение по перемещению
        //    clampedX = Mathf.Clamp(-(mousePos.x / 7000) - 0.7f, minX, maxX);

        //    // Создаем новую позицию, не меняя Y и Z
        //    posEnd = new Vector3(clampedX, rb.position.y, rb.position.z);

        //    // Перемещаем объект к новой позиции
        //    rb.MovePosition(posEnd);
        //}

        else if (!Input.GetMouseButton(0))
            clampedX = 0;
    }
}
