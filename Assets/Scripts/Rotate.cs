﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{       

    public float speed = 2;
    void Update()
    {
        transform.Rotate(0,0,speed);
    }
}
