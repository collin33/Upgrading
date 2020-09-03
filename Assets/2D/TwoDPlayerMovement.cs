using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    public bool isGrounded = false;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Transform GroundCheck;
    public SpriteRenderer sprite;
    public bool flipped;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    public void FixedUpdate()
    {
        if (flipped) sprite.flipX = true; else sprite.flipX = false;
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, whatIsGround);

        //Movement from left to right
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
            flipped = true;
        } else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);
            flipped = false;
        } else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }


        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
