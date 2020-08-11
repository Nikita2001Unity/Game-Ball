
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerr : MonoBehaviour
{
    bool gameHAsEnded = false;
    public float restartDelay = 3f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
        
    {
        if(gameHAsEnded == false)
        {
            gameHAsEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
       
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
