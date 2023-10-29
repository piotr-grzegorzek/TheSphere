using UnityEngine;
using System.Linq;

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
        themes.Where(theme => theme != gameObject).ToList()
            .ForEach(theme => Destroy(theme));
    }
}