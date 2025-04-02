using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLogic : MonoBehaviour
{
    public GameObject OptionsMenu;
    public GameObject MainMenuGame;
    public GameObject RulesMenu;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
     public void Options(){
        OptionsMenu.SetActive(true);
        MainMenuGame.SetActive(false);
    }
     public void Back(){
        OptionsMenu.SetActive(false);
        MainMenuGame.SetActive(true);
    }
    public void Rules(){
        RulesMenu.SetActive(true);
        MainMenuGame.SetActive(false);
        OptionsMenu.SetActive(false);
    }
   
}
