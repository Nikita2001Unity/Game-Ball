using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public static bool GameISPause = false;
    public GameObject pauseMenuUI;


    // Update is called once per frame
   public void PauseMenu()
    {
        if(GameISPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Debug.Log(Time.timeScale);
        GameISPause = true;
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameISPause = false;
        
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
