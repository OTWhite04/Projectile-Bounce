using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 20;
    public float jumpforce = 10f;

    private float inputX;

  

    private void Update()
    {
        inputX = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }

    void Flip()
    {
        if (inputX > 0)
        {
            if (transform.eulerAngles.y != 0f)
            {
                transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
        else
        {
            if (transform.eulerAngles.y != 180f)
            {
                transform.eulerAngles = new Vector3(0f, 180f, 0f);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
        }
    }






}
