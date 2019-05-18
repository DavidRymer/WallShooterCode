using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public GameObject bullet;
    public GameObject firingPoint;
    public GameObject angleCalculator;
    public int bulletSpeed;
    private GameObject bullets;

    void Start()
    {
        bullets = new GameObject();
    }
    void RotateGun()
    {
        if (Input.GetKey(KeyCode.A)) transform.Rotate(0, 0, 2);
        else if (Input.GetKey(KeyCode.D)) transform.Rotate(0, 0, -2);
    }

    void Fire()
    {
        if (Input.GetKey(KeyCode.Space) && bullets.transform.childCount == 0)
        {
            var bulletInMotion = Instantiate(bullet, firingPoint.transform.position, Quaternion.identity);
            bulletInMotion.transform.SetParent(bullets.transform);
            var direction = firingPoint.transform.position - angleCalculator.transform.position;
            var bulletRb2d = bulletInMotion.GetComponent<Rigidbody2D>();
            bulletRb2d.gravityScale = 0;
            bulletRb2d.velocity = direction * bulletSpeed;
            Debug.Log(bulletRb2d.velocity);
            Destroy(bulletInMotion, 5);
         }

    }

    void Update()
    {
        Fire();
        RotateGun();
    }
}
