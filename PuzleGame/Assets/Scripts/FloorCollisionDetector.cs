using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorCollisionDetector : MonoBehaviour
{
    [SerializeField] private GameObject loseScreen;

    private ButtonController buttonController;

    private void Start() {
        buttonController = GetComponent<ButtonController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "weight" || collision.gameObject.tag == "ball")
        {
            print("game over");
            loseScreen.SetActive(true);   
            buttonController.Pause();
        }
    }
}
