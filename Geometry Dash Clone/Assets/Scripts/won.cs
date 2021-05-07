using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class won : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene(SelectLevels.lvlCurrent + 6); //trecem la urm nivel
        SelectLevels.lvlCurrent++;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
