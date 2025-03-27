using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScrypt : MonoBehaviour
{
    public GameObject gameOverUI;
    public Text pointsText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setup(int score){
        gameObject.SetActive(true);
        pointsText.text = score.ToString();     
    }

}
