using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HIGHSCORE", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        playerScore++;
        scoreText.text = "Your Score: " + playerScore.ToString();
        checkHighScore();
    }

    public void checkHighScore()
    {
        if(playerScore > PlayerPrefs.GetInt("HIGHSCORE", 0))
        {
            PlayerPrefs.SetInt("HIGHSCORE", playerScore);
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HIGHSCORE", 0).ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverText.SetActive(true);
    }
}