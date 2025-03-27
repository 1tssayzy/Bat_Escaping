using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2f; // Скорость движения
    public float resetPosition; // Где фон сбрасывается

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        resetPosition = GetComponent<SpriteRenderer>().bounds.size.x; // Берем размер спрайта
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Когда фон уходит за пределы экрана, перемещаем его вперед
        if (transform.position.x <= -resetPosition)
        {
            transform.position += new Vector3(resetPosition * 2, 0, 0);
        }
    }
}