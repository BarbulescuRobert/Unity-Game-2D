using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelViteza : MonoBehaviour
{
    Text niveleViteza;
    int Viteza;
    // Start is called before the first frame update
    void Start()
    {
        niveleViteza = GetComponent<Text>();
        Viteza = ShopScript.lvlViteza - 1;

    }

    // Update is called once per frame
    void Update()
    {
        niveleViteza.text = "Nivel Viteza: " + Viteza;
    }
}
