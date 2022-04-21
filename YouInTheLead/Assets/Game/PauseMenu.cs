using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject PausedMenuUI;

    void Start()
    {
        PausedMenuUI.SetActive(false);
    }

    void Update()
    {
        //Debug.Log("Update!");
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
        PausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu....");
        SceneManager.LoadScene("Menu");
    }

    public void Quit()
    {
        Debug.Log("Quitting game....");
        Application.Quit();
    }
}
