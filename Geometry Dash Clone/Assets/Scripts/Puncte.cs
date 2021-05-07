using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puncte : MonoBehaviour
{
    private bool ok;
    private BoxCollider2D _boxcollider;
    // Start is called before the first frame update
    void Start()
    {
        points.PointsV = 0;
        ok = false;
        _boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ok == false)
        {
            transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f, Space.World);
           // if (transform.rotation.y >= 180)
             //   Debug.Log(transform.rotation.y + "1");
        }
        else
        {
            transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f, Space.World);
           // if (transform.rotation.y <= 0)
              //  Debug.Log(transform.rotation.y + "2");
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 0)
        {
            Destroy(gameObject, 0f);
            points.PointsV++; //Aduna punctele 
        }
    }

}
