using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Constants.Scene.Level1);
    }

    public void ShowOptions()
    {
        // UnityEngine.SceneManagement.SceneManager.LoadScene(Constants.Scene.Options);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
