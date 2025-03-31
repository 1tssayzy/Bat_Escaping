using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScrypt : MonoBehaviour
{
      public int playerScore;
      public Text scoreText;
      public Text highScoreText;
      public GameObject gameOverScreen;
      public GameObject pauseMenuUI;
      public Text preStartText;

     
      [ContextMenu("Increase Score")]
      private void Start()
      {
        Time.timeScale = 1f;
      }
      private void Update()
      {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pauseGame();
        }
      }
      public void addScore(){
        playerScore += 1;
        scoreText.text = playerScore.ToString();
        if(playerScore > PlayerPrefs.GetInt("highScore", 0)){
          PlayerPrefs.SetInt("highScore", playerScore);
          PlayerPrefs.Save();
          UpdateHighScore();
        }
      }
      public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
      public void gameOver(){
        gameOverScreen.SetActive(true); 
        Debug.Log("Game Over");
        UpdateHighScore();
      }
      public void pauseGame(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
      }
      public void StartText(){
        preStartText.gameObject.SetActive(true);
      }
      public void HideText(){
        preStartText.gameObject.SetActive(false);
      }
      public void UpdateHighScore(){
        if (highScoreText != null){
          highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0);
        }
      }
  

      
}
