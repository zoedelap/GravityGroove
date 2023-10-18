using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDetector : MonoBehaviour
{

    [SerializeField] private GameObject winScreen;
    private TextMeshProUGUI winText;

    private int WEIGHTS_DROPPED = 0;

    private string SceneWeightsDroppedVariable;

    private void Start() {
        SceneWeightsDroppedVariable = "WeightsDropped" + SceneManager.GetActiveScene().buildIndex;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            print("you win!");
            winScreen.SetActive(true);
            winText = winScreen.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            winText.SetText("You won using " + WEIGHTS_DROPPED + " weights! Play again to solve the puzzle with fewer weights.");
            PlayerPrefs.SetInt(SceneWeightsDroppedVariable, WEIGHTS_DROPPED);
            print("completed puzzle " + SceneManager.GetActiveScene().buildIndex + " with " + WEIGHTS_DROPPED);
        }
    }

    public void IncrementScore() { 
        WEIGHTS_DROPPED++;
    }
}
