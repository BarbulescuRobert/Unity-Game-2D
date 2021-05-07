using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectLevels : MonoBehaviour
{
    public static int lvlReached;
    public static int lvlCurrent;
    public Button[] levelButtons;
    private void Start()
    {
        //PlayerPrefs.SetInt("Nivele", 1);
        
        lvlReached = PlayerPrefs.GetInt("Nivele", 1); //Nivelul maxim la care am ajuns

        for (int i = 0; i < levelButtons.Length; i++) //Deblocam nivelele noi 
        {
            if (i+1 > lvlReached)
                levelButtons[i].interactable = false;
            else
                levelButtons[i].interactable = true;
        }
       
    }
    public void Level01()
    {
        lvlCurrent = 1;
        SceneManager.LoadScene(6);
    }
    public void Level02()
    {
        lvlCurrent = 2;
        SceneManager.LoadScene(7);
    }
    public void Level03()
    {
        lvlCurrent = 3;
        SceneManager.LoadScene(8);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
