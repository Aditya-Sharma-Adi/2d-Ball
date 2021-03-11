using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public static int speed;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = 50;
    }

    private void FixedUpdate()
    {
        if (GameManager.isplay == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.AddForce(Vector2.right * speed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.AddForce(-Vector2.right * speed);
            }
        }
    }

}
