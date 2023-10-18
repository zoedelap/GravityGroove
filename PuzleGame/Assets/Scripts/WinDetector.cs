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

    private string SceneWeightsDroppedVariableName;
    private string BestSceneWeightsDroppedVariableName;

    private void Start() {
        SceneWeightsDroppedVariableName = "WeightsDropped" + SceneManager.GetActiveScene().buildIndex;
        BestSceneWeightsDroppedVariableName = "BestWeightsDropped" + SceneManager.GetActiveScene().buildIndex;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "goal")
        {
            print("completed puzzle " + SceneManager.GetActiveScene().buildIndex + " with " + WEIGHTS_DROPPED);

            int currentBest = 1_000_000;
            if (PlayerPrefs.HasKey(BestSceneWeightsDroppedVariableName))
            {
                currentBest = PlayerPrefs.GetInt(BestSceneWeightsDroppedVariableName);
                print("current best for this level is " + currentBest);
                if (WEIGHTS_DROPPED < currentBest) {
                    PlayerPrefs.SetInt(BestSceneWeightsDroppedVariableName, WEIGHTS_DROPPED);
                    print("set new best");
                }
            } else {
                PlayerPrefs.SetInt(BestSceneWeightsDroppedVariableName, WEIGHTS_DROPPED);            
            }

            winScreen.SetActive(true);
            winText = winScreen.transform.GetChild(0).transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            if (WEIGHTS_DROPPED < currentBest) {
               winText.SetText("You won using " + WEIGHTS_DROPPED + " weights! You set a new best for this level.");
            } else {
               winText.SetText("You won using " + WEIGHTS_DROPPED + " weights! Play again to solve the puzzle with fewer weights.");
            }

            PlayerPrefs.SetInt(SceneWeightsDroppedVariableName, WEIGHTS_DROPPED);   
        }
    }

    public void IncrementScore() { 
        WEIGHTS_DROPPED++;
    }
}
