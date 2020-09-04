using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject cameraObject;
    public Vector3[] position;
    public float[] cameraSize;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tag1"))
        {
            cameraObject.transform.position = position[1];
            cameraObject.GetComponent<Camera>().orthographicSize = cameraSize[1];
        } 
        else if (collision.gameObject.CompareTag("Tag2"))
        {
            cameraObject.transform.position = position[2];
            cameraObject.GetComponent<Camera>().orthographicSize = cameraSize[2];
        }
        else if (collision.gameObject.CompareTag("Tag3"))
        {
            cameraObject.transform.position = position[3];
            cameraObject.GetComponent<Camera>().orthographicSize = cameraSize[3];
        }
        else if (collision.gameObject.CompareTag("Tag4"))
        {
            cameraObject.transform.position = position[4];
            cameraObject.GetComponent<Camera>().orthographicSize = cameraSize[4];
        }
    }
}