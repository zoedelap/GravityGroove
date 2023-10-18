using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    private TextMeshProUGUI textElem;

    void Start()
    {
        textElem = GetComponent<TextMeshProUGUI>();

        string BestSceneWeightsDroppedVariableName = "BestWeightsDropped" + SceneManager.GetActiveScene().buildIndex;

        int currentBest = 1_000_000;
        if (PlayerPrefs.HasKey(BestSceneWeightsDroppedVariableName)) currentBest = PlayerPrefs.GetInt(BestSceneWeightsDroppedVariableName);

        textElem.SetText("Current Best: " + currentBest.ToString("#,0"));
    }
}
