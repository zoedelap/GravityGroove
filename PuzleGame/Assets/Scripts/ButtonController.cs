using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private WeightSpawner spawner;

    private bool isPaused = false;

    public void LoadNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene(6);
    }

    public void RestartScene() {
        print("reloading scene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        isPaused = !isPaused;
        spawner.SetIsPaused(isPaused);
        if (isPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        // TODO: make the weights not drop if the pause button is pressed
    }
}