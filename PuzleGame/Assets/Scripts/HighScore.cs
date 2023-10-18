using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    [SerializeField] private bool levelHighScore = true;

    private string WeightsDroppedVariable;

    private TextMeshProUGUI text;

    
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();

        text.SetText("You completed all puzzles using " + CalculateTotalWeightsDropped() + " weights total! Play again to solve the puzzles with fewer weights.");
    }

    int CalculateTotalWeightsDropped() {
        int totalWeightsDropped = 0;

        int numScenes = SceneManager.sceneCountInBuildSettings;
        for (int sceneIndex = 0; sceneIndex < numScenes; sceneIndex++)
        {
            WeightsDroppedVariable = "WeightsDropped" + sceneIndex;
            if (PlayerPrefs.HasKey(WeightsDroppedVariable))
            {
                totalWeightsDropped += PlayerPrefs.GetInt(WeightsDroppedVariable);
            }
        }
        return totalWeightsDropped;
    }
}
