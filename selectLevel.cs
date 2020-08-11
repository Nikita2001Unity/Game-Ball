using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class selectLevel : MonoBehaviour
{
    public GameObject panelUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void OpenPanel()
    {
        panelUI.SetActive(true);
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene("level01");
    }
    public void LoadLevel02()
    {
        SceneManager.LoadScene("level02");
    }
    public void LoadLevel03()
    {
        SceneManager.LoadScene("level03");
    }
    public void LoadLevel04()
    {
        SceneManager.LoadScene("level04");
    }
    public void LoadLevel05()
    {
        SceneManager.LoadScene("level05");
    }
    public void LoadLevel06()
    {
        SceneManager.LoadScene("level06");
    }
    public void LoadLevel07()
    {
        SceneManager.LoadScene("level07");
    }
    public void LoadLevel08()
    {
        SceneManager.LoadScene("level08");
    }
    public void LoadLevel09()
    {
        SceneManager.LoadScene("level09");
    }
    public void LoadLevel010()
    {
        SceneManager.LoadScene("level10");
    }

}
