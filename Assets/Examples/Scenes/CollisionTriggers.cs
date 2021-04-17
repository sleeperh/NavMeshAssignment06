using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CollisionTriggers : MonoBehaviour
{
    public GameObject diedPanel;
    public GameObject diedText;
    public GameObject diedButton;

    private void Start()
    {
        diedPanel.SetActive(false);
        diedButton.SetActive(false);
        diedText.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            PointCount.currentScore += 10;
        }
        if (other.gameObject.CompareTag("Ogre"))
        {
            Lives.currentLives -= 1;
            if (Lives.currentLives > 0)
            {
                Time.timeScale = 0;
                diedPanel.SetActive(true);
                diedButton.SetActive(true);
                diedText.SetActive(true);
                PointCount.currentScore = 0;
            }
            else
            {
                PlayerPrefs.SetInt("GameOver", 0);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    public void OKButton()
    {
        diedPanel.SetActive(false);
        diedButton.SetActive(false);
        diedText.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
