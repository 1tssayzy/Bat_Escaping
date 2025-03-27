using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScrypt : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce;
    public double deadZoneBird_YBottom = -4.7;
    public double deadZoneBird_YTop = 5.1;
    public LogicScrypt logic;
    public bool isDead = false;
    private bool isStarted = false;
    void Start()
    {
    logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScrypt>();
    myRigidbody.gravityScale = 0;
    Time.timeScale = 1f;
    logic.StartText();
    }

    void Update()
    {
        if (!isStarted && Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
        if (Input.GetKeyDown(KeyCode.Space) && isDead)
        {
            myRigidbody.velocity = Vector2.up * jumpForce;
        }
        if (transform.position.y < deadZoneBird_YBottom || transform.position.y > deadZoneBird_YTop)
        {
            logic.gameOver();
            Destroy(gameObject); 
            Time.timeScale = 0f;   
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isDead = true;
        Destroy(gameObject);
        Time.timeScale = 0f;
    }
    private void StartGame()
    {
        isStarted = true;
        myRigidbody.gravityScale = 7;
        logic.HideText();
    }
};

