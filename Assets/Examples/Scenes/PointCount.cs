using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PointCount : MonoBehaviour
{
    public static int currentScore;
    public Text pointsText;
    private void Update()
    {
        Debug.Log(PointCount.currentScore);
        pointsText.text = "Points: " + currentScore.ToString();

        if(currentScore == 80)
        {
            PlayerPrefs.SetInt("GameOver", 1);
            SceneManager.LoadScene("GameOver");
        }
    }
}
