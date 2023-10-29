using UnityEngine;
using System.Linq;

public class Theme : MonoBehaviour
{
    public AudioClip Clip;

    private AudioSource _as;

    void Awake()
    {
        DestroyPrevious();
        DontDestroyOnLoad(gameObject);

        _as = GetComponent<AudioSource>();
        _as.clip = Clip;
        _as.Play();
    }

    private void DestroyPrevious()
    {
        GameObject[] themes = GameObject.FindGameObjectsWithTag(Tags.Theme);
        themes.Where(theme => theme != gameObject).ToList()
            .ForEach(theme => Destroy(theme));
    }
}