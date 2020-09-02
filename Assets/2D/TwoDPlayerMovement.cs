using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoDPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    bool isGrounded = false;
    int jumpsLeft;
    public int jumpAmount;
    public float checkRadius;
    public LayerMask whatIsGround;
    public Transform GroundCheck;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, whatIsGround);

        //Movement from left to right
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-1 * speed, rb.velocity.y);
        } else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(1 * speed, rb.velocity.y);
        } else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        //Jumping
        if (isGrounded && rb.velocity.y == 0)
        {
            jumpsLeft = jumpAmount;
        }

        if (Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
