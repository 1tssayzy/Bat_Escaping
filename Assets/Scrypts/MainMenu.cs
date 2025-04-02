using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public GameObject OptionsMenu;
    public GameObject MainMenuGame;
    public GameObject RulesMenu;
  public void PlayGame() {
  RulesMenu.SetActive(true);
    OptionsMenu.SetActive(false);
    MainMenuGame.SetActive(false);
  }
  public void QuitGame() {
    Debug.Log("QUIT!");
    Application.Quit();
  }

    
}
