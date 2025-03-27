using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    public GameObject OptiosMenu;
    public GameObject MainMenu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Options(){
        OptiosMenu.SetActive(true);
        MainMenu.SetActive(false);
    }
     public void Back(){
        OptiosMenu.SetActive(false);
        MainMenu.SetActive(true);
    }
   
}
