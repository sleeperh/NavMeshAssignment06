using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public static int currentLives = 3;
    public Text livesText;
    private void Update()
    {
        livesText.text = "Lives: " + currentLives.ToString();
    }

}
