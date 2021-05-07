using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private BoxCollider2D _boxcollider;

    private bool isGrounded_down; //gravity down (default)
    private bool isGrounded_up; // gravity updown
    public Transform groundcheck_1;
    public Transform groundcheck_2;
    public Transform groundcheck_3;
    public Transform groundcheck_4;
    public float checkRadius;
    public LayerMask Ground;

    public float moveInput;
    public static float speed = 10f;
    public static float jumpForce = 10f;
    public static int extrajumps =0;

    private bool portal;
    private int rot;
    private bool gravity;

    public static int puncterunda = 0;

    public float x;
    public float y;

    public static float xx = -44f;
    public static float yy = 1.2f;

    public Vector3 da;


    void Start()
    {
 
        puncterunda = 0;
        _rigidbody = GetComponent<Rigidbody2D>();
        _boxcollider = GetComponent<BoxCollider2D>();
        if (GameOver.go)
             Respawn();
            //_rigidbody.position = da;
        portal = false;
        gravity = true;
        Fbutton.move = 0;
        Jbutton.jump = false;
    }

    

        // Update is called once per frame
    void Update()
    {

        if (portal == true)
        {
            //Change the gravity to be in a upward direction 
            Physics2D.gravity = new Vector2(0, 10f);
            gravity = false;
        }
        else
        {
            //Change the gravity to be in a downward direction (default)
            Physics2D.gravity = new Vector2(0, -10f);
            gravity = true;
        }
    }
    
    void FixedUpdate()
    {
        if (isGrounded_down == true || isGrounded_up == true)
        {
            extrajumps = 2;
           // x = _rigidbody.position.x;
           // y = _rigidbody.position.y;
        }
        if (Input.GetKeyDown(KeyCode.Space) && extrajumps > 0 && gravity == true)
        {
            // PlayerPrefs.SetFloat("xyz.x", _rigidbody.position.x);
            //PlayerPrefs.SetFloat("xyz.y", _rigidbody.position.y);
            _rigidbody.velocity = Vector2.up * jumpForce;
            extrajumps--;

        }
        if (Input.GetKeyDown(KeyCode.Space) && extrajumps > 0 && gravity == false)
        {
            // PlayerPrefs.SetFloat("xyz.x", _rigidbody.position.x);
            // PlayerPrefs.SetFloat("xyz.y", _rigidbody.position.y);
            _rigidbody.velocity = Vector2.down * jumpForce;
            extrajumps--;
        }


        //if (GameOver.go == true)
          //   Respawn();


        /* if (isGrounded_down == true || isGrounded_up == true)
             {
              extrajumps = 2;
              x = _rigidbody.position.x;
              y = _rigidbody.position.y;
             }
         if (Jbutton.jump == true && extrajumps >= 0)
         {
             if (gravity == true)
             {
                 _rigidbody.velocity = Vector2.up * jumpForce;
             }
             else
             {
                 _rigidbody.velocity = Vector2.down * jumpForce;
             }
             Jbutton.jump = false;
            // Debug.Log(extrajumps);
         }
         */
        rot = (int) _rigidbody.rotation;
        if (rot >= 360)
            while(rot>=360)
                    rot -= 360;
        if (rot < 0)
            while (rot < 0)
                rot += 360;

        if (gravity == true)
        {
            if (rot >= 0 && rot <= 90)
            {
                isGrounded_down = Physics2D.OverlapCircle(groundcheck_1.position, checkRadius, Ground);
                //da = groundcheck_1.position;
            }
            if (rot >= 90 && rot <= 180)
                isGrounded_down = Physics2D.OverlapCircle(groundcheck_2.position, checkRadius, Ground);
            if (rot >= 180 && rot <= 270)
                isGrounded_down = Physics2D.OverlapCircle(groundcheck_3.position, checkRadius, Ground);
            if (rot >= 270 && rot <= 360)
                isGrounded_down = Physics2D.OverlapCircle(groundcheck_4.position, checkRadius, Ground);
        }
        else
        {
            if (rot >= 0 && rot <= 90)
                isGrounded_up = Physics2D.OverlapCircle(groundcheck_3.position, checkRadius, Ground);
            if (rot >= 90 && rot <= 180)
                isGrounded_up = Physics2D.OverlapCircle(groundcheck_4.position, checkRadius, Ground);
            if (rot >= 180 && rot <= 270)
                isGrounded_up = Physics2D.OverlapCircle(groundcheck_1.position, checkRadius, Ground);
            if (rot >= 270 && rot <= 360)
                isGrounded_up = Physics2D.OverlapCircle(groundcheck_2.position, checkRadius, Ground);
        }


        moveInput = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector2(moveInput * speed, _rigidbody.velocity.y); //pentru calculator
        // _rigidbody.velocity = new Vector2(Fbutton.move * speed, _rigidbody.velocity.y); //pentru telefon

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9) //atinge ceva ce il omoara
        {
            Omoruri.omoruri++;
            SceneManager.LoadScene(5); // trece la scena de "Died"
        }
        if (collision.gameObject.layer == 11)
            portal = true;
        if (collision.gameObject.layer == 12)
            portal = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Finish") // Daca ajunge la finish 
        {
            puncterunda = points.PointsV; // Punctele pe fiecare runda

            if (SelectLevels.lvlCurrent == 1)
                punctelvl1.plvl1 = puncterunda;

            highscore.PuncteMaxim += puncterunda; // Punctele de la stats
            ShopPuncte.puncte += points.PointsV; //Punctele pe care le poti folosi

            if (SelectLevels.lvlCurrent == SelectLevels.lvlReached) //Daca trecem de ultimul nivel
            {
                SelectLevels.lvlReached++; //Putem accesa urmatorul nivel
                PlayerPrefs.SetInt("Nivele", SelectLevels.lvlReached); //Memoram numarul de nivele
            }

            SceneManager.LoadScene(4); //Scena "Won"
        }
    }

    public void Respawn()
    {
        // Debug.Log("" + x + " " + y);
      //  x = PlayerPrefs.GetFloat("x", -44f);
      //  y = PlayerPrefs.GetFloat("y", 1.2f);
            _rigidbody.position = new Vector3(xx , yy ,0f);
            GameOver.go = false;
    }
}
