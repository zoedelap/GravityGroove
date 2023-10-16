using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    private void Start() {

    }

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
        // SceneManager.LoadScene("_scene_1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}