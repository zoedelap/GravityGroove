using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private bool overallBest = false;
    private TextMeshProUGUI textElem;

    void Start()
    {
        textElem = GetComponent<TextMeshProUGUI>();

        string BestWeightsDroppedVariableName;
        if (overallBest) {
            BestWeightsDroppedVariableName = "BestWeightsDroppedTotal";
        } else {
            BestWeightsDroppedVariableName = "BestWeightsDropped" + SceneManager.GetActiveScene().buildIndex;
        }

        int currentBest = 1_000_000;
        if (PlayerPrefs.HasKey(BestWeightsDroppedVariableName)) currentBest = PlayerPrefs.GetInt(BestWeightsDroppedVariableName);

        if (overallBest) {
            textElem.SetText("Current Overall Best: " + currentBest.ToString("#,0"));
        } else {
            textElem.SetText("Current Best: " + currentBest.ToString("#,0"));

        }
    }
}
