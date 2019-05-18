using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{

    public GameObject lives;
    public GameObject level;
    public GameObject targets;

    void UpdateLives() => lives.GetComponent<Text>().text = "Lives: " + targets.GetComponent<GameController>().lives;
    
    void UpdateLevel() => level.GetComponent<Text>().text = SceneManager.GetActiveScene().name;


    // Update is called once per frame
    void Update()
    {
        UpdateLives();  
        UpdateLevel();
    }
}
