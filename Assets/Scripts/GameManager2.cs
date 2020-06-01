using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public static GameManager instance;
    public int score = 0;
    public GameObject WinText, ResumegameCanvas,pauseButton;
    public Button Pause;
    public Button Resume;

    public void ScoreUp()
    {
        score++;
        if (score >= 8)
        {
            Win();
        }
    }

    public void Win()
    {
        WinText.gameObject.SetActive(true);
        Invoke("NextLevel", 2f);
    }

    void NextLevel()
    {
        SceneManager.LoadScene("Game 2");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().ToString());
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
