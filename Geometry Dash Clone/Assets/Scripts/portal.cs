using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
 
    private BoxCollider2D _boxcollider;
    // Start is called before the first frame update
    void Start()
    {
        _boxcollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 0)
            Destroy(gameObject, 0f);
    }

}
