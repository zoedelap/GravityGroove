using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        print("Collision with goal detected");
        if (collision.gameObject.tag == "goal")
        {
            print("you win!");
            // load the next scene in the build index
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
