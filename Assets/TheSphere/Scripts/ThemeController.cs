using UnityEngine;
using Constant;

public class ThemeController : MonoBehaviour
{
    public AudioClip MainMenuTheme;
    public AudioClip Level1Theme;

    private AudioSource _as;

    internal void ChangeToMainMenuClip()
    {
        _as.clip = MainMenuTheme;
        _as.Play();
    }
    internal void ChangeToGameClip()
    {
        _as.clip = Level1Theme;
        _as.Play();
    }

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag(Tag.Theme);

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            _as = GetComponent<AudioSource>();
            ChangeToMainMenuClip();
        }
    }
}
