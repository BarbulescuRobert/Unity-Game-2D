using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NivelCompletate : MonoBehaviour
{
    Text nivelecompl;
    // Start is called before the first frame update
    void Start()
    {
        nivelecompl = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        nivelecompl.text = "Nivele completate: " + SelectLevels.lvlCurrent;
    }
}
