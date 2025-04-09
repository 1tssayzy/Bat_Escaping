using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float speed = 2f; 
    public float resetPosition; 

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
        resetPosition = GetComponent<SpriteRenderer>().bounds.size.x; 
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -resetPosition)
        {
            transform.position += new Vector3(resetPosition * 2, 0, 0);
        }
    }
}