using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPuncte : MonoBehaviour
{
    Text Punctee;
    public static int puncte = 80;
    void Start()
    {
        Punctee = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Punctee.text = "" + puncte;
    }
}
