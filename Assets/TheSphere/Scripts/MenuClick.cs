using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = Constant.Scene;
using Tag = Constant.Tag;

public class MenuClick : MonoBehaviour
{
    public void Run()
    {
        SceneManager.LoadScene(Scene.Level1);
        GameObject.FindGameObjectWithTag(Tag.Theme).GetComponent<ThemeController>().ChangeToGameClip();
    }

    public void HighScores()
    {
        SceneManager.LoadScene(Scene.HighScores);
    }

    public void Options()
    {
        Debug.Log("Options");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu);
        if (SceneManager.GetActiveScene().name != Scene.HighScores)
        {
            GameObject.FindGameObjectWithTag(Tag.Theme).GetComponent<ThemeController>().ChangeToMainMenuClip();
        }
    }
}
