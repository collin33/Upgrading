﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Camera_Rotation : MonoBehaviour
{

    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}