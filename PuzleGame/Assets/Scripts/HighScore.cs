using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    private TextMeshProUGUI text;
    
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();

        string BestTotalWeightsDroppedVariableName = "BestWeightsDroppedTotal";

        int totalWeightsDropped = CalculateTotalWeightsDropped();
        int currentBest = 1_000_000;
        if (PlayerPrefs.HasKey(BestTotalWeightsDroppedVariableName))
        {
            currentBest = PlayerPrefs.GetInt(BestTotalWeightsDroppedVariableName);
            print("current best overall is " + currentBest);
            if (totalWeightsDropped < currentBest) {
                PlayerPrefs.SetInt(BestTotalWeightsDroppedVariableName, totalWeightsDropped);
                print("set new best");
            }
        } else {
            PlayerPrefs.SetInt(BestTotalWeightsDroppedVariableName, totalWeightsDropped);            
        }
        
        if (totalWeightsDropped < currentBest) {
            text.SetText("You completed all puzzles using " + CalculateTotalWeightsDropped() + " weights total! You set a new best overall score.");
        } else {
            text.SetText("You completed all puzzles using " + CalculateTotalWeightsDropped() + " weights total! Play again to solve the puzzles with fewer weights.");
        }
    }

    int CalculateTotalWeightsDropped() {
        int totalWeightsDropped = 0;

        int numScenes = SceneManager.sceneCountInBuildSettings;
        for (int sceneIndex = 0; sceneIndex < numScenes; sceneIndex++)
        {
            string WeightsDroppedVariable = "WeightsDropped" + sceneIndex;
            if (PlayerPrefs.HasKey(WeightsDroppedVariable))
            {
                totalWeightsDropped += PlayerPrefs.GetInt(WeightsDroppedVariable);
            }
        }
        return totalWeightsDropped;
    }
}
