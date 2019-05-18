using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public int lives = 3;

    public void TakeLife() => lives -= 1;

    private void OnCollisionEnter2D(Collision2D other)
    {
        var sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);
        var a = 0;
        System.Int32.TryParse(sceneName.Split(' ')[1], out a);
        SceneManager.LoadScene("Level " + (a + 1));
    }

    private void Update() {
        if (lives == 0) {
            SceneManager.LoadScene("Level 1");
        }
    }

}
