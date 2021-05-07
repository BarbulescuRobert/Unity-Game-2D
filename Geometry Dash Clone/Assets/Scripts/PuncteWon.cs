using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuncteWon : MonoBehaviour
{
    // Start is called before the first frame update
    Text punctele;
    private void Start()
    {
        punctele = GetComponent<Text>();
    }
    private void Update()
    {
        punctele.text = "+" + points.PointsV;
    }
}
