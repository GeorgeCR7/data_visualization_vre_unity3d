using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject buttonsCanvas;
    public GameObject musicCanvas;
    public GameObject controlsCanvas;
    public GameObject quitPage;

    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }   
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        buttonsCanvas.SetActive(true);
        musicCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        buttonsCanvas.SetActive(false);
        musicCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void ControlsMenu()
    {
        controlsCanvas.SetActive(true);
        pauseMenuUI.SetActive(false);
        musicCanvas.SetActive(false);
    }

    public void BackFromControlsMenu()
    {
        controlsCanvas.SetActive(false);
        pauseMenuUI.SetActive(true);
        musicCanvas.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        quitPage.SetActive(true);
        pauseMenuUI.SetActive(false);
        musicCanvas.SetActive(false);
    }

    public void YesQuitGame()
    {
        Application.Quit();
    }

    public void NoQuitGame()
    {
        quitPage.SetActive(false);
        pauseMenuUI.SetActive(true);
        musicCanvas.SetActive(true);
    }
}