using UnityEngine;
using Constant;

public class ThemeController : MonoBehaviour
{
    public AudioClip Clip;

    private AudioSource _as;

    void Awake()
    {
        DestroyPrevious();

        _as = GetComponent<AudioSource>();
        _as.clip = Clip;
        _as.Play();

        DontDestroyOnLoad(gameObject);
    }

    private void DestroyPrevious()
    {
        GameObject[] themes = GameObject.FindGameObjectsWithTag(Tag.Theme);

        foreach (var theme in themes)
        {
            if (theme != gameObject)
            {
                Destroy(theme);
                Debug.Log($"Destroyed {theme.name}");
            }
        }
    }
}
