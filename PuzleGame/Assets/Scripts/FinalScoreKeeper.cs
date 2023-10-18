using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScoreKeeper : MonoBehaviour
{
    private int TOTAL_WEIGHTS_DROPPED = 0;

    private TextMeshProUGUI text;

    
    void Start()
    {
        text = transform.GetComponent<TextMeshProUGUI>();

        int numScenes = SceneManager.sceneCountInBuildSettings;
        for (int sceneIndex = 0; sceneIndex < numScenes; sceneIndex++)
        {
            string SceneWeightsDroppedVariable = "WeightsDropped" + sceneIndex;
            if (PlayerPrefs.HasKey(SceneWeightsDroppedVariable))
            {
                TOTAL_WEIGHTS_DROPPED += PlayerPrefs.GetInt(SceneWeightsDroppedVariable);
            }
        }
        text.SetText("You completed all puzzles using " + TOTAL_WEIGHTS_DROPPED + " weights total! Play again to solve the puzzles with fewer weights.");
        print("total weights dropped: " + TOTAL_WEIGHTS_DROPPED);
    }

}
