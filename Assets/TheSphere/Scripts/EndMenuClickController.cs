using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuClickController : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
