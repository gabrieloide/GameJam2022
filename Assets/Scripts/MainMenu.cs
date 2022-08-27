using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    public GameObject MenuPause;
    public bool IsPaused;

    public void loadScene1()
    {
        SceneManager.LoadScene("Chapter1");
    }

    public void loadScene2()
    {
        SceneManager.LoadScene("Chapter2");
    }

    public void loadScene3()
    {
        SceneManager.LoadScene("Chapter3");
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    private void Awake()
    {
        if (instance = null)
        {
            instance = this;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        MenuPause.SetActive(true);
        Time.timeScale = 0;
        IsPaused = true;
    }
    public void Resume()
    {
        MenuPause.SetActive(false);
        Time.timeScale = 1;
        IsPaused = false;
    }

    public void exit()
    {
        Application.Quit();
    }
}
