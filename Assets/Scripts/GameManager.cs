using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public GameObject WinText, ResumegameCanvas,pauseButton;
    public Button Pause;
    public Button Resume;

    void Start()
    {
        
    }
    public void ScoreUp()
    {
        score++;
        if (score >= 6)
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
        Time.timeScale = 0;
        ResumegameCanvas.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        ResumegameCanvas.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);

    }

}
