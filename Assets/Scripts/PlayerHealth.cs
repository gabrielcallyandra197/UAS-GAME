using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth instance;

    public int health;
    public int maxHealth = 3;
    public int score = 0;
    

    

    public SpriteRenderer playerSr;
    public PlayerController playerController;

    public GameObject gameOverScreen;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameScoreText;
    
    
   private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        gameOverScreen.SetActive(false);
        UpdateScoreText();
        
        
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {

            playerSr.enabled = false;
            playerController.enabled = false;
            GameOver();
        }
       
    }

    

    public void AddScore(int points)
    {
        Data.score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if(gameScoreText != null)
        {
            gameScoreText.text = "Kamu Mendapatkan Keris O " + Data.score.ToString();
        }
    }

     void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreText.text = "Kamu Hanya Mendapatkan Keris: " + Data.score.ToString();
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        health = maxHealth;
        Data.score = 0;

        UpdateScoreText();
        

        gameOverScreen.SetActive(false);

        Time.timeScale = 1f;
        SceneManager.LoadScene("Gameplay 1");
    }

   public void ResetScore()
    {
        Data.score = 0;
    }

}
