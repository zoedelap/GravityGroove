using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        print("Collision with goal detected");
        if (collision.gameObject.tag == "goal")
        {
            print("you win!");
        }
    }
}
