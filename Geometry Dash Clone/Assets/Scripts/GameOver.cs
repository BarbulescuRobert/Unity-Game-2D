using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject video;
    public GameObject gatavideo;
    public static bool go = false;

    public void Go()
    {
        go = true;
       // Debug.Log("" + SelectLevels.lvlCurrent);
        SceneManager.LoadScene(SelectLevels.lvlCurrent + 5);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SelectLevels.lvlCurrent+5); //Repetam nivelul
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
