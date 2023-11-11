using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = Constant.Scene;

public class EndMenuClick : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(Scene.MainMenu);
    }
}
