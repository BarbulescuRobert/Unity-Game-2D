using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private bool ok;
    // Start is called before the first frame update
    void Start()
    {
        ok = true ;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ( ok == false)
        {
            transform.position += new Vector3(0f, 4f * Time.deltaTime, 0f);
            if (transform.position.y >= -2)
                ok = true;
        }
        if ( ok == true)
        {
            transform.position -= new Vector3(0f, 4f * Time.deltaTime, 0f);
            if (transform.position.y <= -11)
                ok = false;
        }
    }
}
