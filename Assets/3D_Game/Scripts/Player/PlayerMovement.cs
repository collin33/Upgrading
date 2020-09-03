using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 10f;
    public float gravity = -9.8f;
    public float jumpHight;
    bool isGrounded;

    Vector3 velocity;

    public Transform groundCheck;
    public float distance = 0.4f;
    public LayerMask groundMask;

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, distance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 Movement = transform.right * x + transform.forward * z;

        controller.Move(Movement * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        

        controller.Move(velocity * Time.deltaTime);
    }
}
