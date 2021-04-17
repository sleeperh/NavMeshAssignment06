using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    public Text gameOverTxt;
    public Text pointsTxt;
    public Text livesTxt;
    // Start is called before the first frame update
    void Start()
    {
        pointsTxt.text = "Points: " + PointCount.currentScore.ToString();
        livesTxt.text = "Lives: " + Lives.currentLives.ToString();

        if(PlayerPrefs.GetInt("GameOver")==1)
        {
            gameOverTxt.text = "You Win!";
        }
        else
        {
            gameOverTxt.text = "You Lose!";
        }
    }

    public void RestartGame()
    {
        Lives.currentLives = 3;
        PointCount.currentScore = 0;
        SceneManager.LoadScene("Main");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You Quit");
    }
}
