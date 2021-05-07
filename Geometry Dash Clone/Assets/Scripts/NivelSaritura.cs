using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelSaritura : MonoBehaviour
{
    Text niveleSaritura;
    int Saritura;
    // Start is called before the first frame update
    void Start()
    {
        niveleSaritura = GetComponent<Text>();
        Saritura = ShopScript.lvlSaritura - 1;

    }

    // Update is called once per frame
    void Update()
    {
        niveleSaritura.text = "Nivel Saritura: " + Saritura;
    }
}
