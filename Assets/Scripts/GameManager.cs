using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public GameObject WinText;
    public bool isPaused = false;
    
    public void ScoreUp()
    {
        score++;
        if (score >= 2)
        {
            Win();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Win()
    {
        WinText.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void PauseGame()
    {
        if(isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
            Restart();
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            
        }
    }

}
