using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class coliderrr : MonoBehaviour
{
    public Transform ceva;
    private BoxCollider2D _boxcollider;
    private void Start()
    {
        _boxcollider = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8) //atinge barile
        {
           //  PlayerPrefs.SetFloat("x",ceva.position.x);
          //   PlayerPrefs.SetFloat("y",ceva.position.y);
            Player.xx = ceva.position.x;
            Player.yy = ceva.position.y;
        }
    }
}
