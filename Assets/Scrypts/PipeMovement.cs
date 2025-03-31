using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed = 2;
    private float deadZone = -45;
     
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position  += (Vector3.left * speed) * Time.deltaTime;
         if (transform.position.x < deadZone)  {
            Destroy(gameObject);
         } 
    }
}
