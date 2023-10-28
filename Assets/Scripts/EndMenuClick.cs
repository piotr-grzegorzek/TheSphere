using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuClick : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
