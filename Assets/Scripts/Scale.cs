using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    public int speed = 5;
    private void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
    }

}


