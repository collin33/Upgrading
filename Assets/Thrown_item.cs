using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrown_item : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("destory");
            Destroy(gameObject);
        }
    }
}
