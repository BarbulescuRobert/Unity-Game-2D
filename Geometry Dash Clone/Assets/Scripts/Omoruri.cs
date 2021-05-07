using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Omoruri : MonoBehaviour
{
    Text OOmoruri;
    public static int omoruri = 0;
    // Start is called before the first frame update
    void Start()
    {
        OOmoruri = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        OOmoruri.text = "Omoruri: " + omoruri;
    }
}
