using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDetector : MonoBehaviour
{

    [SerializeField] private GameObject winScreen;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            print("you win!");
            winScreen.SetActive(true);
        }
    }
}
