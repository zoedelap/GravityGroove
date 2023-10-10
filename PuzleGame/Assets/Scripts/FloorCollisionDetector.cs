using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "weight" || collision.gameObject.tag == "ball")
        {
            print("game over");
        }
    }
}
