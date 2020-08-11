
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menu : MonoBehaviour
{
    public AudioClip au;
    public AudioSource ms;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void StartAudio()
    {
        ms.GetComponent<AudioSource>();
        ms.clip = au;
        ms.Play();
    }
}
