using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuButtonManager : MonoBehaviour
{

    [SerializeField] private Button playButton;
    [SerializeField] private Button restartLevelButton;
    [SerializeField] private Button pauseButton;

    [SerializeField] private WeightSpawner spawner;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        playButton?.onClick.AddListener(LoadFirstLevel);
        restartLevelButton?.onClick.AddListener(RestartLevel);
        pauseButton?.onClick.AddListener(Pause);
    }

    private void LoadFirstLevel()
    {
        SceneManager.LoadScene("_scene_0");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Pause()
    {
        isPaused = !isPaused;
        spawner.SetIsPaused(isPaused);
        if (isPaused) 
        {
            Time.timeScale = 0;
        } else
        {
            Time.timeScale = 1;
        }
        // TODO: make the weights not drop if the pause button is pressed
    }


}
