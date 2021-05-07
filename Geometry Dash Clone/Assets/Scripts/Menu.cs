using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    /*public void Levels()
    {
        SceneManager.LoadScene(1);
    }*/
    public void Stats()
    {
        SceneManager.LoadScene(3);
    }
    public void Shop()
    {
        SceneManager.LoadScene(2);
    }
}
