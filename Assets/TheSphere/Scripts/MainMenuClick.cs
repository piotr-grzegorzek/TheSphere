using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = Constant.Scene;

public class MainMenuClick : MonoBehaviour
{
    public void Run()
    {
        SceneManager.LoadScene(Scene.Level1);
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
