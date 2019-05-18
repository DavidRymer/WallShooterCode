using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    private GameObject targets;

    private void Start()
    {
        targets = FindTargets();
    }

    private GameObject FindTargets()
    {
        var gameObjects = FindObjectsOfType<GameObject>();

        foreach (var a in gameObjects)
        {
            if (a.transform.name == "Targets")
            {
                return a;
            }
        }

        return null;
    }

    private void OnDestroy() {
        var controller = targets.GetComponent<GameController>();
        if(controller.lives > 0) controller.lives -= 1;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    
        TargetCollision(other);
    }

    

    private void TargetCollision(Collision2D other)
    {
       // if (other.transform.name.Contains("Target")) Destroy(gameObject, 2);
    }

}
