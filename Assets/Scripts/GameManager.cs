using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score = 0;
    public GameObject WinText, ResumegameCanvas, pauseButton;
    public Button Pause;
    public Button Resume;
    public int balls;
    public string currentLevel, nextLevel;
    

    public void ScoreUp()
    {
        score++;
        if (score >= balls)
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
        SceneManager.LoadScene(nextLevel.ToString());
    }

    public void Restart()
    {
        SceneManager.LoadScene(currentLevel.ToString());
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
