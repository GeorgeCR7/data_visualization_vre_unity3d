using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject playButton;
    public GameObject aboutButton;
    public GameObject quitButton;
    public GameObject aboutPage, quitPage;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void AboutGame()
    {
        playButton.SetActive(false);
        aboutButton.SetActive(false);
        quitButton.SetActive(false);
        aboutPage.SetActive(true);
    }

    public void BackFromAboutPage()
    {
        playButton.SetActive(true);
        aboutButton.SetActive(true);
        quitButton.SetActive(true);
        aboutPage.SetActive(false);
    }

    public void QuitGame()
    {
        quitPage.SetActive(true);
        playButton.SetActive(false);
        aboutButton.SetActive(false);
        quitButton.SetActive(false);
    }

    public void YesQuitGame()
    {
        Application.Quit();
    }

    public void NoQuitGame()
    {
        quitPage.SetActive(false);
        playButton.SetActive(true);
        aboutButton.SetActive(true);
        quitButton.SetActive(true);
    }
}
