using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public static int PuncteMaxim = 0;
    Text Highscore;

    // Start is called before the first frame update
    void Start()
    {
        Highscore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Highscore.text = "Puncte Totale: " + PuncteMaxim;
    }
}
