using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public Text scoreText;
    public void ShowGameOverScreen(int score)
    {
        scoreText.text = "" + score.ToString();
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }
    public void RetryButtonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

