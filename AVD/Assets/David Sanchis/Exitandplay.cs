using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitandplay : MonoBehaviour
{
    public void doExitGame()
    {
        Application.Quit();
    }

    public void playButton(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
