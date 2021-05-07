using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class punctelvl1 : MonoBehaviour
{
    public static int plvl1 = 0;
    Text punctele;
    private void Start()
    {
        punctele = GetComponent<Text>();
    }
    private void Update()
    {
        punctele.text = plvl1 + "/5";
    } 
}
