using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScript : MonoBehaviour
{
    public GameObject[] viteza;
    public GameObject SfarsitViteza;
    public static int lvlViteza = 1;
    private int[] costViteza = { 5, 10, 15, 20, 30 };
    private static bool gataViteza = false;

    public GameObject[] saritura;
    public GameObject SfarsitSaritura;
    public static int lvlSaritura = 1;
    private int[] costSaritura = { 5, 10, 15, 20, 30 };
    private static bool gataSaritura = false;


    private void Start()
    {
        //lvlViteza = PlayerPrefs.GetInt("lvViteza", 0); //NR la care am ajuns cu abilitatea "Viteza"
        if (gataViteza == false)
        {
            for (int i = 0; i < costViteza.Length; i++)
            {

                if (lvlViteza - 1 == i)
                    viteza[i].SetActive(true);
                else
                    viteza[i].SetActive(false);
            }
        }
        else
        {
            viteza[lvlViteza - 1].SetActive(false);
            SfarsitViteza.SetActive(true);
        }
        //lvlSaritura = PlayerPrefs.GetInt("lvSaritura", 0); //NR la care am ajuns cu abilitatea "Saritura"
        if (gataSaritura == false)
        {
            for (int i = 0; i < costSaritura.Length; i++)
            {

                if (lvlSaritura - 1 == i)
                    saritura[i].SetActive(true);
                else
                    saritura[i].SetActive(false);
            }
        }
        else
        {
            saritura[lvlSaritura - 1].SetActive(false);
            SfarsitSaritura.SetActive(true);
        }
    }
    public void Viteza()
    {
        

        if (lvlViteza == costViteza.Length && ShopPuncte.puncte >=costViteza[lvlViteza -1])
        {
            Player.speed += 5f;
            ShopPuncte.puncte -= costViteza[lvlViteza - 1];
            viteza[lvlViteza - 1].SetActive(false);
            SfarsitViteza.SetActive(true);
            gataViteza = true;

        }
        if (lvlViteza != costViteza.Length && ShopPuncte.puncte >= costViteza[lvlViteza - 1])
        {
            for (int i = 0; i < costViteza.Length; i++)
            {
                
                if (lvlViteza== i)
                    viteza[i].SetActive(true);
                else
                    viteza[i].SetActive(false);
            }
            Player.speed += 5f;
            ShopPuncte.puncte -= costViteza[lvlViteza - 1];
            lvlViteza++;
            //PlayerPrefs.SetInt("lvViteza", lvlViteza); //Setam nivelul care am ajuns
            
        }
        else
            Debug.Log("nu ai destule puncte");

    }
    public void Saritura()
    {


        if (lvlSaritura == costSaritura.Length && ShopPuncte.puncte >= costSaritura[lvlSaritura - 1])
        {
            Player.jumpForce += 5f;
            ShopPuncte.puncte -= costSaritura[lvlSaritura - 1];
            saritura[lvlSaritura - 1].SetActive(false);
            SfarsitSaritura.SetActive(true);
            gataSaritura = true;

        }
        if (lvlSaritura != costSaritura.Length && ShopPuncte.puncte >= costSaritura[lvlSaritura - 1])
        {
            for (int i = 0; i < costSaritura.Length; i++)
            {

                if (lvlSaritura == i)
                    saritura[i].SetActive(true);
                else
                    saritura[i].SetActive(false);
            }
            Player.jumpForce += 5f;
            ShopPuncte.puncte -= costSaritura[lvlSaritura - 1];
            lvlSaritura++;
            //PlayerPrefs.SetInt("lvSaritura", lvlSaritura); //Setam nivelul care am ajuns

        }
        else
            Debug.Log("nu ai destule puncte");

    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
