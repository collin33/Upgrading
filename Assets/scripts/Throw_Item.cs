using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Item : MonoBehaviour
{
    public GameObject GameObject;
    public Transform SpawnPoint;
    public Rigidbody Prefab;
    Rigidbody Rb;

    void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }



    void Update()
    {
        for(int i =0; i<1; i--)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("space is down");
                Rb = Instantiate(Prefab, SpawnPoint.position, SpawnPoint.rotation) as Rigidbody;
                Rb.useGravity = false;
                GameObject.transform.position = SpawnPoint.transform.position;
                GameObject.transform.rotation = SpawnPoint.transform.rotation;
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log("space is released");
                Rb.AddForce(transform.forward * 500);
                Rb.AddForce(transform.up * 300);
                Rb.useGravity = true;
            }

            if (i == 5)
            {
                Destroy(Prefab);
            }

        }



        

    }

   /* void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision");
        if (collision.gameObject.CompareTag ("Ground"))
        {
            Debug.Log("destory");
            Destroy(GameObject);
        }
    }*/
}
