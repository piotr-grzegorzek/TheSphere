using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuClick : MonoBehaviour
{
    public void Run()
    {
        SceneManager.LoadScene(1);
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
