using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject LevelSelect;
    public GameObject RulesMenu;
    public void SelectLevel() {
        LevelSelect.SetActive(true);
        RulesMenu.SetActive(false);
    }
    public void PlayGameEasy() {
        SceneManager.LoadScene(1);
    }
    public void PlayGameHard() {
        SceneManager.LoadScene(2);
    }
}
